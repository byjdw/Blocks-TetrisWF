using AS_Coursework.enums;
using AS_Coursework.game;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.models
{
    [Serializable]
    internal class Block
    {
        private int id;
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
            this.id = new Random().Next(0, 1000000); 
        }

        public void AdjustX(GameWindow gameWindow, int adjX)
        {
            Console.WriteLine($"X: {x} => {x + adjX}");
            RenderNext(gameWindow, x + adjX, y);
        }

        public void Descend(GameWindow gameWindow)
        {
            Console.WriteLine($"Y: {y} => {y + 1}");
            RenderNext(gameWindow, x, y + 1);
        }

        public void Rotate(GameWindow gameWindow)
        {

        }

        private void RenderNext(GameWindow gameWindow, int x, int y)
        {
            if (Idle) return;
            List<int[]> newBlock = GenerateCoordinates(x, y);
            bool[] validation = ValidatesTiles(gameWindow, newBlock);
            if (!validation[0]) return;
            if (y > 0)
            {
                List<int[]> oldBlock = GenerateCoordinates(this.x, this.y);
                foreach (int[] pos in oldBlock)
                {
                    PictureBox oldTile = gameWindow.GetTileFromCoordinates(pos[0], pos[1]);
                    oldTile.Image = Properties.Resources.Empty;
                    oldTile.Tag = "Empty";
                    Console.WriteLine($"Changed tile @ [{pos[0]}, {pos[1]}].");
                }
            }
            foreach (int[] pos in newBlock)
            {
                PictureBox newTile = gameWindow.GetTileFromCoordinates(pos[0], pos[1]);
                newTile.Image = blockTile;
                newTile.Tag = id.ToString();
                Console.WriteLine($"Changed tile @ [{pos[0]}, {pos[1]}].");
            }

            this.x = x;
            this.y = y;
            if (this.y == maxY - 1) Idle = true;
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
                    x = 2;
                    y = -1;
                    break;
                case BlockType.SQUARE:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 1, y - 1 });
                    blockTile = Properties.Resources.Board_Square;
                    x = 4;
                    y = 0;
                    break;
                case BlockType.Z:
                    generatedCoordinates.Add(new int[] { x, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    blockTile = Properties.Resources.Board_Z;
                    x = 2;
                    y = 0;
                    break;
                case BlockType.S:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 1, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 2, y - 1 });
                    blockTile = Properties.Resources.Board_S;
                    x = 2;
                    y = 0;
                    break;
                case BlockType.L:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    blockTile = Properties.Resources.Board_L;
                    x = 2;
                    y = 0;
                    break;
                case BlockType.REVERSE_L:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    generatedCoordinates.Add(new int[] { x + 2, y - 1 });
                    blockTile = Properties.Resources.Board_Reverse_L;
                    x = 2;
                    y = 0;
                    break;
                case BlockType.T:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    generatedCoordinates.Add(new int[] { x + 1, y - 1 });
                    blockTile = Properties.Resources.Board_T;
                    x = 3;
                    y = 0;
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
                    if (tile != null)
                    {


                        if (
                            !tile.Tag.Equals("Empty") &&
                            !(tile.Tag.Equals(id.ToString()))
                        )
                        {
                            Console.WriteLine($"Tile @ [{x},{y}] is NOT Valid.");
                            if (x != this.x)
                            {
                                validX = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Tile @ [{x},{y}] is Valid.");
                        }
                    } else
                    {
                        validX = false;
                    }
                    } catch
                {
                    Console.WriteLine($"Tile @ [{x},{y}] out of bounds!");
                    validX = false;
                }
            }
            return new bool[] { validX, validY };
        }

        public override string ToString()
        {
            return $"BLOCK: Idle {Idle}, X: {x}, Y: {y}";
        }
    }
}
