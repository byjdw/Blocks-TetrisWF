using System;
using System.Collections.Generic;
using AS_Coursework.enums;
using AS_Coursework.game;
using AS_Coursework.@internal;
using AS_Coursework.io;

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

    public void AdjustX(int x)
    {
        CurrentBlock.AdjustX(instance, x);
    }

    public void Rotate()
    {
        CurrentBlock.Rotate(instance);
    }

    public void GameOver()
    {
        var player = SessionManager.CurrentPlayer;
        player.AllScore += Score;
        if (Score > player.HighScore)
        {
            player.HighScore = Score;
            player.PersonalRecords += 1;
        }

        player.BlocksPlaced += BlocksPlaced;
        player.Games += 1;
        player.Ticks += Ticks;
        SessionManager.CurrentPlayer = player;
        DataManager.OverwritePlayer(player);
        DataManager.SavePlayers();
    }

    public void Save(List<string> tiles, List<string> tags)
    {
        CurrentBlock.Hide(instance);
        var player = SessionManager.CurrentPlayer;
        var gameState = new GameState();
        gameState.Score = Score;
        gameState.Multiplier = Multiplier;
        gameState.CurrentBlock = CurrentBlock;
        gameState.HeldBlock = HeldBlock;
        gameState.BlockQueue = BlockQueue;
        gameState.BlocksPlaced = n;
        gameState.Ticks = Ticks;
        gameState.Tiles = tiles;
        gameState.Tags = tags;
        player.PreviousGameState = gameState;
        SessionManager.CurrentPlayer = player;
        DataManager.OverwritePlayer(player);
        DataManager.SavePlayers();
        Environment.Exit(0);
    }

    public void AddScore(int lines, int adj)
    {
        var sc = 0;
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

        Score += sc + adj;
    }
}