using AS_Coursework.enums;
using AS_Coursework.game;
using AS_Coursework.@internal;
using AS_Coursework.io;
using System;
using System.Collections.Generic;

namespace AS_Coursework.models;

public class GameSession
{
    // Session Information
    private GameWindow instance;
    private int score;
    private double multiplier;
    bool usedHold;
    int n;
    int t;

    // Block Storage
    private Block? current; // Current Block
    private Block? held;
    private List<Block> queue; // Future Blocks

    public GameSession(GameWindow instance)
    {
        n = 0;
        score = 0;
        multiplier = 1;
        queue = new List<Block>();
        for (int i = 0; i < 4; i++)
        {
            BlockType type = (BlockType)Random.Shared.Next(Enum.GetValues(typeof(BlockType)).Length);
            queue.Add(new Block(n, type, instance.boardWidth, instance.boardHeight));
            n += 1;
        }
        usedHold = false;
        this.instance = instance;
        Console.WriteLine(instance.boardHeight);
    }

    public GameSession(GameWindow instance, GameState gameState)
    {
        score = gameState.Score;
        multiplier = gameState.Multiplier;
        current = new Block(gameState.CurrentBlock.Id, gameState.CurrentBlock.Type, instance.boardWidth, instance.boardHeight);
        held = gameState.HeldBlock;
        queue = new List<Block>();
        foreach (Block block in gameState.BlockQueue)
        {
            queue.Add(new Block(block.Id, block.Type, instance.boardWidth, instance.boardHeight));
        }
        n = gameState.BlocksPlaced;
        t = gameState.Ticks;
        this.instance = instance;
    }

    public int Score { get => score; }
    public double Multiplier { get => multiplier; }
    public Block CurrentBlock { get => current; }
    public Block HeldBlock { get => held; }
    public List<Block> BlockQueue { get => queue; }
    public int BlocksPlaced { get => n + 1; }
    public int Ticks { get => t; }

    public void Tick()
    {
        if (instance.Halt) return;
        if (!instance.Tick) return;
        if (current == null)
        {
            instance.Interval = (int)(1000 / multiplier);
            current = queue[0];
            queue.RemoveAt(0);
            BlockType type = (BlockType)Random.Shared.Next(Enum.GetValues(typeof(BlockType)).Length);
            queue.Add(new Block(n, type, instance.boardWidth, instance.boardHeight));
            n += 1;
        }
        if (!instance.Tick) return;
        if (instance.Halt) return;
        current.Descend(instance);
        if (instance.Interval == 50) AddScore(0, 1);
        if (instance.Interval == 1) AddScore(0, 2);
        if (current.Idle)
        {
            instance.Interval = 100;
            current = null;
            usedHold = false;
            instance.CheckLines();
            return;
        }
        Console.WriteLine(current.ToString());
        t += 1;
    }

    public void Hold()
    {
        if (usedHold) return;
        if (held == null)
        {
            current.Hide(instance);
            held = new Block(current.Id, current.Type, instance.boardHeight, instance.boardHeight);
            current = queue[0];
            current.AdjustX(instance, 0);
            queue.RemoveAt(0);
            BlockType type = (BlockType)Random.Shared.Next(Enum.GetValues(typeof(BlockType)).Length);
            queue.Add(new Block(n, type, instance.boardWidth, instance.boardHeight));
            n += 1;
        }
        else
        {
            current.Hide(instance);
            Block temp = new Block(current.Id, current.Type, instance.boardHeight, instance.boardHeight);
            current = new Block(held.Id, held.Type, instance.boardHeight, instance.boardHeight);
            current.AdjustX(instance, 0);
            held = temp;
        }
        usedHold = true;
    }

    public void AdjustX(int x) => current.AdjustX(instance, x);

    public void Rotate() => current.Rotate(instance);

    public void GameOver()
    {
        Player player = SessionManager.CurrentPlayer;
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

    public void Save(List<String> tiles, List<String> tags)
    {
        current.Hide(instance);
        Player player = SessionManager.CurrentPlayer;
        GameState gameState = new GameState();
        gameState.Score = score;
        gameState.Multiplier = multiplier;
        gameState.CurrentBlock = current;
        gameState.HeldBlock = held;
        gameState.BlockQueue = queue;
        gameState.BlocksPlaced = n;
        gameState.Ticks = t;
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
        int sc = 0;
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
        score += sc + adj;
    }
}