using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.models
{
    [Serializable]
    internal class GameSession
    {
        private int score;
        private double tick;
        public Block current;
        public List<Block> queue;
        private List<Block> blocks;

        public GameSession()
        {
            tick = 1000;
            score = 0;
            queue = new List<Block>();
            blocks = new List<Block>();
        }

        public void Tick(int x, int y, TableLayoutPanel gameBoard)
        {

        }
    }
}
