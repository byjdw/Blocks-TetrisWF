using AS_Coursework.enums;
using AS_Coursework.game;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Windows.Forms;

namespace AS_Coursework.models
{
    [Serializable]
    internal class Block
    {
        // Block Configuration
        private BlockType type;
        public Image tile;
        private int id;
        bool idle;

        // Position Tracking
        private int x;
        private int y;
        private int r;
        private int maxX;
        private int maxY;
        private int maxR;



        public bool Idle { get => idle; set => idle = value; }

        public Block(int id, BlockType type, int maxX, int maxY)
        {
            this.id = id;
            this.type = type;
            this.maxX = maxX;
            this.maxY = maxY;
            this.x = 3;
            this.y = 1;
            this.r = 0;
            this.maxR = 3;
            switch (type)
            {
                case BlockType.LINE:
                    tile = Properties.Resources.Board_Line;
                    this.y = -1;
                    this.maxR = 0;
                    break;
                case BlockType.SQUARE:
                    tile = Properties.Resources.Board_Square;
                    this.maxR = 1;
                    break;
                case BlockType.Z:
                    tile = Properties.Resources.Board_Z;
                    this.maxR = 1;
                    break;
                case BlockType.S:
                    tile = Properties.Resources.Board_S;
                    this.maxR = 1;
                    break;
                case BlockType.L:
                    tile = Properties.Resources.Board_L;
                    break;
                case BlockType.REVERSE_L:
                    tile = Properties.Resources.Board_Reverse_L;
                    break;
                case BlockType.T:
                    tile = Properties.Resources.Board_T;
                    break;
            }
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
            List<int[]> newBlock = GenerateCoordinates(x, y);
            bool[] validation = ValidatesTiles(gameWindow, newBlock);
            if (this.y == maxY - 1 || !validation[1]) Idle = true;
            if (Idle) return;
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
                newTile.Image = tile;
                newTile.Tag = id.ToString();
                Console.WriteLine($"Changed tile @ [{pos[0]}, {pos[1]}].");
            }

            this.x = x;
            this.y = y;
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
                    break;
                case BlockType.SQUARE:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 1, y - 1 });
                    break;
                case BlockType.Z:
                    generatedCoordinates.Add(new int[] { x, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    break;
                case BlockType.S:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 1, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 2, y - 1 });
                    break;
                case BlockType.L:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y - 1 });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    break;
                case BlockType.REVERSE_L:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    generatedCoordinates.Add(new int[] { x + 2, y - 1 });
                    break;
                case BlockType.T:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x + 1, y });
                    generatedCoordinates.Add(new int[] { x + 2, y });
                    generatedCoordinates.Add(new int[] { x + 1, y - 1 });
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
                            if (coordinates[0][0] != this.x)
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
