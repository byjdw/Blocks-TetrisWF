using AS_Coursework.enums;
using AS_Coursework.game;
using AS_Coursework.@internal;
using AS_Coursework.io;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AS_Coursework.models;

public class GameSession
{
    // Block Storage

    // Session Information
    private readonly GameWindow instance;
    private int n;
    private bool usedHold;

    public GameSession(GameWindow instance)
    {
        n = 0;
        Score = 0;
        Multiplier = 1;
        BlockQueue = new List<Block>();
        for (var i = 0; i < 4; i++)
        {
            var type = (BlockType)Random.Shared.Next(Enum.GetValues(typeof(BlockType)).Length);
            BlockQueue.Add(new Block(n, type, instance.boardWidth, instance.boardHeight));
            n += 1;
        }

        usedHold = false;
        this.instance = instance;
        Console.WriteLine(instance.boardHeight);
    }

    public GameSession(GameWindow instance, GameState gameState)
    {
        Score = gameState.Score;
        Multiplier = gameState.Multiplier;
        CurrentBlock = new Block(gameState.CurrentBlock.Id, gameState.CurrentBlock.Type, instance.boardWidth,
            instance.boardHeight)
        {
            Pos = gameState.CurrentBlock.Pos
        };
        HeldBlock = gameState.HeldBlock;
        BlockQueue = new List<Block>();
        foreach (var block in gameState.BlockQueue)
            BlockQueue.Add(new Block(block.Id, block.Type, instance.boardWidth, instance.boardHeight));
        n = gameState.BlocksPlaced;
        Ticks = gameState.Ticks;
        this.instance = instance;
    }

    public int Score { get; private set; }

    public double Multiplier { get; }

    public Block CurrentBlock { get; private set; }

    public Block HeldBlock { get; private set; }

    public List<Block> BlockQueue { get; }

    public int BlocksPlaced => n + 1;
    public int Ticks { get; private set; }

    public void Tick()
    {
        if (instance.Halt) return;
        if (!instance.Tick) return;
        if (CurrentBlock == null)
        {
            instance.Interval = (int)(1000 / Multiplier);
            CurrentBlock = BlockQueue[0];
            BlockQueue.RemoveAt(0);
            var type = (BlockType)Random.Shared.Next(Enum.GetValues(typeof(BlockType)).Length);
            BlockQueue.Add(new Block(n, type, instance.boardWidth, instance.boardHeight));
            n += 1;
        }

        if (!instance.Tick) return;
        if (instance.Halt) return;
        CurrentBlock.Descend(instance);
        if (instance.Interval == 50) AddScore(0, 1);
        if (instance.Interval == 1) AddScore(0, 2);
        if (CurrentBlock.Idle)
        {
            instance.Interval = 100;
            CurrentBlock = null;
            usedHold = false;
            instance.CheckLines();
            return;
        }

        Console.WriteLine(CurrentBlock.ToString());
        Ticks += 1;
    }

    public void Hold()
    {
        if (usedHold) return;
        if (HeldBlock == null)
        {
            CurrentBlock.Hide(instance);
            HeldBlock = new Block(CurrentBlock.Id, CurrentBlock.Type, instance.boardHeight, instance.boardHeight);
            CurrentBlock = BlockQueue[0];
            CurrentBlock.AdjustX(instance, 0);
            BlockQueue.RemoveAt(0);
            var type = (BlockType)Random.Shared.Next(Enum.GetValues(typeof(BlockType)).Length);
            BlockQueue.Add(new Block(n, type, instance.boardWidth, instance.boardHeight));
            n += 1;
        }
        else
        {
            CurrentBlock.Hide(instance);
            var temp = new Block(CurrentBlock.Id, CurrentBlock.Type, instance.boardHeight, instance.boardHeight);
            CurrentBlock = new Block(HeldBlock.Id, HeldBlock.Type, instance.boardHeight, instance.boardHeight);
            CurrentBlock.AdjustX(instance, 0);
            HeldBlock = temp;
        }

        usedHold = true;
    }

    /// <summary>
    /// It adjusts the X value of the current block by the supplied value.
    /// </summary>
    public void AdjustX(int x)
    {
        CurrentBlock.AdjustX(instance, x);
    }

    /// <summary>
    /// It rotates the current block.
    /// </summary>
    public void Rotate()
    {
        CurrentBlock.Rotate(instance);
    }


    /// <summary>
    /// It gets the current player from the session manager, adds the score to the player's total score, and
    /// if the score is greater than the player's high score, it sets the player's high score to the score
    /// and increments the player's personal records. It also records other misc statistics, overwrites the
    /// SessionManager's player cache, and saves the player's data to a file
    /// </summary>
    /// <returns>
    /// The player's data.
    /// </returns>
    public void GameOver()
    {
        /* Getting the current player from the session manager. */
        var Player = SessionManager.CurrentPlayer;
        if (Player == null) return;
        /* Adding the score to the player's total score, and if the score is greater than the player's high
        score, it sets the player's high score to the score and increments the player's personal records. */
        if (!Player.IsGuest) return;
        Player.AllScore += Score;
        if (Score > Player.HighScore)
        {
            Player.HighScore = Score;
            Player.PersonalRecords += 1;
        }

        /* Recording other misc statistics. */
        Player.BlocksPlaced += BlocksPlaced;
        Player.Games += 1;
        Player.Ticks += Ticks;
        /* Overwriting the SessionManager's player cache and Saving the player's data to a file. */
        SessionManager.CurrentPlayer = Player;
        DataManager.OverwritePlayer(Player);
        DataManager.SavePlayers();
    }

    /// <summary>
    /// It saves the current game state to a file
    /// </summary>
    /// <param name="GameWindow">The current instance of the game window.</param>
    /// <param name="tiles">A list of strings that represent the tiles on the board.</param>
    /// <param name="tags">A list of strings that represent the tags of the blocks that are currently on the board.</param>
    public void Save(GameWindow instance, List<string> tiles, List<string> tags)
    {
        var Player = SessionManager.CurrentPlayer;
        if (Player == null) return;
        if (Player.IsGuest)
        {
            instance.GameOver();
            return;
        }
        instance.Close();

        var gameState = new GameState()
        {
            Score = Score,
            Multiplier = Multiplier,
            CurrentBlock = CurrentBlock,
            HeldBlock = HeldBlock,
            BlockQueue = BlockQueue,
            BlocksPlaced = n,
            Ticks = Ticks,
            Tiles = tiles,
            Tags = tags
        };

        Player.PreviousGameState = gameState;
        SessionManager.CurrentPlayer = Player;
        DataManager.OverwritePlayer(Player);
        DataManager.SavePlayers();
        MessageBox.Show("Your progress has been saved successfully.",
            "Blocks · Save Game Confirmation",
            MessageBoxButtons.OK,
           MessageBoxIcon.Exclamation);
        SessionManager.MainMenuForm.Show();
    }



    /// <summary>
    /// "Add the score based on the number of lines cleared and the adjustment value provided."
    /// </summary>
    /// <param name="lines">The number of lines cleared.</param>
    /// <param name="adj">The adjustment value.</param>
    public void AddScore(int lines, int adj)
    {
        var sc = 0;
        /* Adding the score based on the number of lines cleared. */
        switch (lines)
        {
            case 2:
            case 3:
                sc += lines * 200 - 100;
                break;
            case 4:
                sc += 800;
                break;
        }

        /* Adding the score based on the number of lines cleared and the adjustment value. */
        Score += sc + adj;
    }
}