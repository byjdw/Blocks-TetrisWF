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
        private double speed;
        public Block current;
        public List<Block> queue;
        private List<Image> tiles;

        public GameSession()
        {
            score = 0;
            speed = 1;
           
            queue = new List<Block>();
            tiles = new List<Image>();
        }

        public void Tick(int x, int y, TableLayoutPanel gameBoard)
        {

        }
    }
}
