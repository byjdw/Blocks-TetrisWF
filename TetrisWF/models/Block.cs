using System;
using System.Collections.Generic;
using System.Drawing;

namespace AS_Coursework.models
{
    [Serializable]
    internal class Block
    {
        private string type;
        public List<int[]> positions;
        public Image blockTile;

        public Block(string type, int rotation, int x, int y)
        {
            this.type = type;
            switch (type) {
                case "line":
                    blockTile = Properties.Resources.Board_Line;
                    positions = new List<int[]>()
                        {
                            new int[] {x, y},
                            new int[] {x + 1, y},
                            new int[] {x + 2, y},
                            new int[] {x + 3, y}
                        };
                    break;
                case "square":
                    blockTile = Properties.Resources.Board_Square;
                    positions = new List<int[]>()
                        {
                            new int[] {x, y},
                            new int[] {x, y + 1},
                            new int[] {x + 1, y},
                            new int[] {x + 1, y + 1}
                        };
                    break;
                default:
                    throw new Exception("Invalid block type!");
                    break;
            }
        }
    }
}
