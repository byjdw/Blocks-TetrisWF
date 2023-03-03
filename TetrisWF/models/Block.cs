using AS_Coursework.enums;
using AS_Coursework.game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.models
{
    [Serializable]
    internal class Block
    {
        private int x = 0;
        private int y = 0;
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
            Console.WriteLine($"X: {x} => {x + adjX}");
            RenderNext(gameWindow, x + adjX, y);
        }

        public void Descend(GameWindow gameWindow)
        {
            RenderNext(gameWindow, x, y + 1);
        }

        public void FastFall(GameWindow gameWindow)
        {
            RenderNext(gameWindow, x, y + ((maxY - 1) - y));
        }

        public void Rotate(GameWindow gameWindow)
        {

        }

        private void RenderNext(GameWindow gameWindow, int x, int y)
        {
            if (Idle) return;
            bool blockObstructedX = false;
            bool blockObstructedY = false;
            List<int[]> newBlock = GenerateCoordinates(x, y);
            List<int[]> oldBlock = GenerateCoordinates(this.x, this.y);
            bool[] validation = ValidatesTiles(gameWindow, newBlock);
            // if (!validation[0]) return;
            for (int i = 0; i < newBlock.Count; i++)
            {
                PictureBox newTile = gameWindow.GetTileFromCoordinates(newBlock[i][0], newBlock[i][1]);
                newTile.Image = blockTile;
                newTile.Tag = "Occupied";
                Console.WriteLine($"Changed tile @ [{newBlock[i][0]},{newBlock[i][1]}].");
                if (y > 0)
                {
                    PictureBox oldTile = gameWindow.GetTileFromCoordinates(oldBlock[i][0], oldBlock[i][1]);
                    oldTile.Image = Properties.Resources.Empty;
                    oldTile.Tag = "Empty";
                    Console.WriteLine($"Changed tile @ [{oldBlock[i][0]},{oldBlock[i][1]}].");
                }

            }

            if (this.y == maxY - 1) Idle = true;
            else
            {
                this.x = x;
                this.y = y;
            }

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

        private bool[] ValidatesTiles(GameWindow gameWindow, List<int[]> coordinates)
        {
            bool validX = true;
            bool validY = true;
            foreach (int[] pos in coordinates)
            {
                int x = pos[0];
                int y = pos[1];
                try
                {
                    PictureBox tile = gameWindow.GetTileFromCoordinates(x, y);
                    if (!tile.Tag.Equals("Empty"))
                    {
                        Console.WriteLine($"Tile @ [{x},{y}] is NOT Valid.");
                        if (x != this.x)
                        {
                            validX = false;
                        } else
                        {
                            validY = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Tile @ [{x},{y}] is Valid.");
                    }
                } catch
                {
                    Console.WriteLine($"Tile @ [{x},{y}] out of bounds!");
                    validX = false;
                }

            }
            return new bool[] { validX, validY };
        }

    }
}
