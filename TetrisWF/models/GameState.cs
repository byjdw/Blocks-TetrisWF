using System;
using System.Collections.Generic;

namespace AS_Coursework.models
{
    [Serializable]
    public class GameState
    {
        // Session Information
        private int score;
        private double multiplier;
        int n;
        int t;

        // Block Storage
        private Block? current; // Current Block
        private Block? held; // Held Block
        private List<Block> queue; // Future Blocks
        private List<String> tiles; // Cached Tiles
        private List<String> tags; // Cached Tags

        // Properties Get:Set
        public int Score { get => score; set => score = value; }
        public double Multiplier { get => multiplier; set => multiplier = value; }
        public Block CurrentBlock { get => current; set => current = value; }
        public Block HeldBlock { get => held; set => held = value; }
        public List<Block> BlockQueue { get => queue; set => queue = value; }
        public int BlocksPlaced { get => n; set => n = value; }
        public int Ticks { get => t; set => t = value; }

        public List<String> Tiles { get => tiles; set => tiles = value; }
        public List<String> Tags { get => tags; set => tags = value; }
    }
}
