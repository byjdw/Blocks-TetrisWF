using System;
using System.Collections.Generic;

namespace AS_Coursework.models
{

    [Serializable]
    public class GameState
    {
        // Block Storage
        private Block? current; // Current Block
        private Block? held; // Held Block
        private double multiplier; // Speed Multiplier
        private int n; // Block Count
        private List<Block> queue; // Future Blocks
        private int score; // Total Game Score

        // Session Information
        private int clearedLines; // Total Game Ticks

        // Board Information
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

        public int ClearedLines
        {
            get => clearedLines;
            set => clearedLines = value;
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
}