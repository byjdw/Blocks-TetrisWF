using AS_Coursework.enums;
using AS_Coursework.game;
using System;
using System.Collections.Generic;

namespace AS_Coursework.models;

[Serializable]
public class GameSession
{
    // Session Information
    private int score;
    private double multiplier;
    bool usedHold;
    int n;

    // Block Storage
    private Block? current; // Current Block
    private Block? held;
    private List<Block> blocks; // Historic Blocks
    private List<Block> queue; // Future Blocks

    public GameSession()
    {

    }

    public GameSession(GameWindow instance)
    {
        n = 0;
        score = 0;
        multiplier = 1;
        queue = new List<Block>();
        blocks = new List<Block>();
        for (int i = 0; i < 4; i++)
        {
            BlockType type = (BlockType)Random.Shared.Next(Enum.GetValues(typeof(BlockType)).Length);
            queue.Add(new Block(n, type, instance.boardWidth, instance.boardHeight));
            n += 1;
        }
        usedHold = false;
    }

    public int Score { get => score; }
    public Block CurrentBlock { get => current; }
    public Block HeldBlock { get => held; }
    public List<Block> BlockQueue { get => queue; } 

    public void Tick(GameWindow instance)
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
            blocks.Add(current);
            current = null;
            usedHold = false;
            instance.CheckLines();
            return;
        }
        Console.WriteLine(current.ToString());
    }

    public void Hold(GameWindow instance)
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
            queue.Add(new Block(blocks.Count + 1, type, instance.boardWidth, instance.boardHeight));
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