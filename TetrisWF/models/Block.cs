using AS_Coursework.enums;
using AS_Coursework.game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AS_Coursework.models
{
    [Serializable]
    internal class Block
    {
        private int x = 0;
        private int y = -1;
        private int maxX;
        private int maxY;
        private BlockType type;
        public Image blockTile;
        bool idle;

        public bool Idle { get => idle; set => idle = value; }

        public Block(BlockType type, int maxX, int maxY)
        {
            this.type = type;
            this.maxX = maxX;
            this.maxY = maxY;
        }

        public void AdjustX(GameWindow gameWindow, int adjX)
        {
            RenderNext(gameWindow, x + adjX, y);
        }

        public void AdjustY(GameWindow gameWindow, int adjY)
        {
            RenderNext(gameWindow, x, y + adjY);
        }

        private void RenderNext(GameWindow gameWindow, int x, int y)
        {
            if (Idle) return;
            gameWindow.UpdateDebugInfo($"old: {this.x}, {this.y}\nnew {x}, {y}\nmax {maxX}, {maxY}");
            foreach (int[] pos in GenerateCoordinates(x, y))
            {
                // if (pos[0] < 0 || pos[0] > (maxX - 1)) return;
                PictureBox tile = gameWindow.GetTileFromCoordinates(pos[0], pos[1]);
                tile.Image = blockTile;
            }
            if (y > 0)
            {
                foreach (int[] pos in GenerateCoordinates(this.x, this.y))
                {
                    PictureBox tile = gameWindow.GetTileFromCoordinates(pos[0], pos[1]);
                    tile.Image = Properties.Resources.Empty;
                }
            }

            this.x = x;
            this.y = y;
            if (this.y == maxY - 1) Idle =true;

        }

        private List<int[]> GenerateCoordinates(int x, int y)
        {
            List<int[]> generatedCoordinates = new List<int[]>();
            switch (type)
            {
                case BlockType.LINE:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    generatedCoordinates.Add(new int[] { x + 3, y });
                    blockTile = Properties.Resources.Board_Line;
                    break;
                case BlockType.SQUARE:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y + 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 1, y + 1 });
                    blockTile = Properties.Resources.Board_Square;
                    break;
                case BlockType.Z:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x, y + 1 });
                    generatedCoordinates.Add(new int[] { x - 1, y + 1 });
                    blockTile = Properties.Resources.Board_Z;
                    break;
                case BlockType.S:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x - 1, y });
                    generatedCoordinates.Add(new int[] { x, y + 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y + 1 });
                    blockTile = Properties.Resources.Board_S;
                    break;
                case BlockType.L:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y + 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    blockTile = Properties.Resources.Board_L;
                    break;
                case BlockType.REVERSE_L:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    generatedCoordinates.Add(new int[] { x + 2, y + 1 });
                    blockTile = Properties.Resources.Board_Reverse_L;
                    break;
                case BlockType.T:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y + 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x - 1, y });
                    blockTile = Properties.Resources.Board_T;
                    break;
            }
            return generatedCoordinates;
        }


    }
}
