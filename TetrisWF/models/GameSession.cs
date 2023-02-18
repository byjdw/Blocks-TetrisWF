using System;
using System.Collections.Generic;

namespace AS_Coursework.models
{
    [Serializable]
    internal class GameSession
    {
        private int score;
        private double time;
        private double speed;
        public List<Block> queue;
        private List<Block> blocks;

        public GameSession()
        {
            queue = new List<Block>();
            queue.Add(new Block(0, 1, false, 0, 0));
        }

        public void Tick()
        {

        }
    }
}
