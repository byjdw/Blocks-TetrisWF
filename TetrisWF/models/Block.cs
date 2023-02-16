using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework.models
{
    [Serializable]
    internal class Block
    {
        int id;
        int type;
        public int rotation;
        public bool rotatable;
        public int[,] positionOffsets;
        public Image blockTile;
        public Color blockColor;

        public Block(int id, int type, bool rotatable, int x, int y)
        {
            this.id = id;
            this.type = type;
            this.rotatable = rotatable;

                    blockColor = Color.Yellow;
                    blockTile = Properties.Resources.Square;
                    positionOffsets = new int[,] { { x, y }, { x, y + 1 }, { x + 1, y }, { x + 1, y + 1 } };
            
        }
    }
}
