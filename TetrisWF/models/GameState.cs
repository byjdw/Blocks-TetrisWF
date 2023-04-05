using System;
using System.Collections.Generic;

namespace AS_Coursework.models
{

    [Serializable]
    public class GameState
    {
        private Block? current;
        private Block? held;
        private double multiplier;
        private int blockCount;
        private List<Block> queue;
        private int score;
        private int clearedLines;
        private List<string> tags;
        private List<string> tiles;

        public int Score { get => score; set => score = value; }
        public double Multiplier { get => multiplier; set => multiplier = value; }
        public Block? CurrentBlock { get => current; set => current = value; }
        public Block? HeldBlock { get => held; set => held = value; }
        public List<Block> BlockQueue { get => queue; set => queue = value; }
        public int BlocksPlaced { get => blockCount; set => blockCount = value; }
        public int ClearedLines { get => clearedLines; set => clearedLines = value; }
        public List<string> Tiles { get => tiles; set => tiles = value; }
        public List<string> Tags { get => tags; set => tags = value; }
    }
}
