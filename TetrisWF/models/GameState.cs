using System;
using System.Collections.Generic;

namespace AS_Coursework.models;

[Serializable]
public class GameState
{
    // Block Storage
    private Block? current; // Current Block
    private Block? held; // Held Block
    private double multiplier;
    private int n;

    private List<Block> queue; // Future Blocks

    // Session Information
    private int score;
    private int t;
    private List<string> tags; // Cached Tags
    private List<string> tiles; // Cached Tiles

    // Properties Get:Set
    public int Score
    {
        get => score;
        set => score = value;
    }

    public double Multiplier
    {
        get => multiplier;
        set => multiplier = value;
    }

    public Block CurrentBlock
    {
        get => current;
        set => current = value;
    }

    public Block HeldBlock
    {
        get => held;
        set => held = value;
    }

    public List<Block> BlockQueue
    {
        get => queue;
        set => queue = value;
    }

    public int BlocksPlaced
    {
        get => n;
        set => n = value;
    }

    public int Ticks
    {
        get => t;
        set => t = value;
    }

    public List<string> Tiles
    {
        get => tiles;
        set => tiles = value;
    }

    public List<string> Tags
    {
        get => tags;
        set => tags = value;
    }
}