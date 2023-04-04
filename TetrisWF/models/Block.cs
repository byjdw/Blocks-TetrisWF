using AS_Coursework.enums;
using AS_Coursework.forms.game;
using AS_Coursework.io;
using AS_Coursework.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.models
{

    [Serializable]
    public class Block
    {
        // Position Tracking
        private Position position;
        private int r;
        private int moves;

        // Block Boundaries
        private readonly int maxR;
        private readonly int maxX;
        private readonly int maxY;

        // Block Configuration
        private int id;
        private bool idle;
        private Image tile;
        private BlockType type;


        public Block() { } // For resuming of game.

        public Block(int id, BlockType type, int maxX, int maxY)
        {
            this.id = id;
            this.type = type;
            this.maxX = maxX;
            this.maxY = maxY;
            this.r = 0;
            this.maxR = 3;
            position = new Position { x = 4, y = 0 };

            switch (type) // Initialise block params for blocks that require it;;
            {
                case BlockType.LINE:
                    position.y = -1; // This block is only 1 tile tall in default pos; custom start y set;
                    maxR = 1; // Set maximum rotation value;
                    break;
                case BlockType.SQUARE:
                    maxR = 0; // Set maximum rotation value;
                    break;
                case BlockType.Z:
                case BlockType.S:
                    maxR = 1; // Set maximum rotation value;
                    break;
            }

            tile = DataManager.Tiles[(int)type];
            tile.Tag = type.ToString();
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public BlockType Type
        {
            get => type;
            set => type = value;
        }

        public bool Idle
        {
            get => idle;
            set => idle = value;
        }

        public Position Pos
        {
            get => position;
            set => position = value;
        }

        /// <summary>
        ///     It adjusts the X position of the block by the amount specified in the parameter
        /// </summary>
        /// <param name="GameWindow">The instance of the game window.</param>
        /// <param name="adjX">The amount to adjust the X position by.</param>
        public void AdjustX(GameWindow instance, int adjX)
        {
            RenderNextFrame(instance, position.x + adjX, position.y,
                r); // Calls RenderNext() with params causing the block to move horizontally.
        }

        /// <summary>
        ///     It calls RenderNext() with params causing the block to descend by 1
        /// </summary>
        /// <param name="GameWindow">The instance of the game window.</param>
        public void Descend(GameWindow instance)
        {
            RenderNextFrame(instance, position.x, position.y + 1,
                r); // Calls RenderNext() with params causing the block to descend by 1.
        }

        /// <summary>
        ///     It takes the current rotation, adds one to it, and if it's greater than the maximum rotation, it
        ///     sets it to zero.
        ///     The next step is to call the `RenderNext` function, which is the function that actually draws the
        ///     next shape.
        /// </summary>
        /// <param name="GameWindow">The instance of the game window.</param>
        public void Rotate(GameWindow instance)
        {
            var newR = r + 1;
            if (newR > maxR) newR = 0;
            RenderNextFrame(instance, position.x, position.y, newR);
        }

        /// <summary>
        ///     It renders the next block
        /// </summary>
        /// <param name="GameWindow">The instance of the game window.</param>
        /// <param name="x">The x position of the block.</param>
        /// <param name="y">The y-coordinate of the block.</param>
        /// <param name="r">Rotation</param>
        private void RenderNextFrame(GameWindow instance, float x, float y, int r)
        {
            var NewBlock = GeneratePositions(x, y, r);
            var PositionValidation = ValidateTiles(instance, NewBlock);
            if (!PositionValidation[1])
                if (moves == 0) instance.GameOver();
                else idle = true;
            if (!PositionValidation[0]) return;
            if (idle) return;
            instance.SuspendLayout();
            this.Hide(instance);
            // Calculate the ghost block positions.
            List<Position> GhostBlock = GenerateGhostBlockPositions(instance, x, y, r);
            foreach (var pos in GhostBlock)
            {
                RenderTile(instance, pos.x, pos.y, Resources.Ghost, id.ToString());
            }

            // Render the new block.
            foreach (var pos in NewBlock)
            {
                RenderTile(instance, pos.x, pos.y, tile, id.ToString());
            }

            instance.ResumeLayout(true);

            if (y == position.y)
                if (r == this.r) DataManager.PlaySoundEffect("move");
                else DataManager.PlaySoundEffect("rotate");

            position.x = x;
            position.y = y;
            this.r = r;
            moves += 1;
        }

        private void RenderTile(GameWindow instance, float x, float y, Image tile, String tag)
        {
            PictureBox Cell = instance.GetCellFromCoordinates((int)Math.Round(x), (int)Math.Round(y));
            RenderTile(instance, Cell, tile, tag);
        }

        private void RenderTile(GameWindow instance, PictureBox cell, Image tile, String tag)
        {
            if (cell != null)
            {
                cell.Image = tile;
                cell.Tag = tag;
            }
        }



        private List<Position> GenerateGhostBlockPositions(GameWindow instance, float x, float y, int rotation)
        {
            int row = (int)Math.Round(x);
            int column = (int)Math.Round(y);
            List<Position> positions = GeneratePositions(row, column, rotation);
            {
                bool ValidGhostPlacement = true;
                while (ValidGhostPlacement)
                {
                    List<Position> NewGhostBlock = GeneratePositions(x, positions[0].y + 1, rotation);
                    bool[] ValidGhostBlock = ValidateTiles(instance, NewGhostBlock);
                    if (ValidGhostBlock[0] && ValidGhostBlock[1]) positions = NewGhostBlock;
                    else ValidGhostPlacement = false;
                }
            }

            return positions;
        }



        /// <summary>
        ///     It hides the block by replacing the tiles with empty tiles
        /// </summary> 
        /// <param name="GameWindow">The instance of the game window.</param>
        public void Hide(GameWindow instance)
        {
            instance.SuspendLayout();
            List<PictureBox> OccupiedCells = new List<PictureBox>();
            foreach (PictureBox BoardCell in instance.Cells)
                if (Convert.ToString(BoardCell.Tag) == id.ToString()) OccupiedCells.Add(BoardCell);
            foreach (PictureBox Cell in OccupiedCells) RenderTile(instance, Cell, Resources.Empty, "Empty");
            instance.ResumeLayout(true);

        }

        /// <summary>
        ///     It takes a row, column, and rotation, and returns a list of positions that represent the block in
        ///     that state.
        /// </summary>
        /// <param name="row">the row of the block</param>
        /// <param name="column">the column of the block</param>
        /// <param name="r">rotation</param>
        /// <returns>
        ///     A list of positions.
        /// </returns>
        private List<Position> GeneratePositions(float row, float column, int r)
        {
            var tilePositions = new List<Position>();
            var x = (int)row;


            var y = (int)column;
            switch (type)
            {
                case BlockType.LINE:
                    tilePositions.Add(new Position(0, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(-1, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(1, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(2, 0).rotate(90 * r) + new Position(x, y));
                    break;
                case BlockType.SQUARE:
                    tilePositions.Add(new Position(0, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(0, -1).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(1, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(1, -1).rotate(90 * r) + new Position(x, y));
                    break;
                case BlockType.Z:
                    tilePositions.Add(new Position(0, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(-1, -1).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(0, -1).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(1, 0).rotate(90 * r) + new Position(x, y));
                    break;
                case BlockType.S:
                    tilePositions.Add(new Position(0, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(-1, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(0, -1).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(1, -1).rotate(90 * r) + new Position(x, y));
                    break;
                case BlockType.L:
                    tilePositions.Add(new Position(0, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(-1, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(-1, -1).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(1, 0).rotate(90 * r) + new Position(x, y));
                    break;
                case BlockType.REVERSE_L:
                    tilePositions.Add(new Position(0, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(-1, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(1, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(1, -1).rotate(90 * r) + new Position(x, y));
                    break;
                case BlockType.T:
                    tilePositions.Add(new Position(0, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(-1, 0).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(0, -1).rotate(90 * r) + new Position(x, y));
                    tilePositions.Add(new Position(1, 0).rotate(90 * r) + new Position(x, y));
                    break;
            }

            return tilePositions;
        }

        /// <summary>
        ///     It checks if the tiles are valid for the current piece's next movement
        /// </summary>
        /// <param name="GameWindow">The instance of the game window.</param>
        /// <param name="positions">A list of positions that the piece is going to be occupying.</param>
        /// <returns>
        ///     A boolean array.
        /// </returns>
        private bool[] ValidateTiles(GameWindow instance, List<Position> positions)
        {
            var baseX = (int)Math.Round(positions[0].x);
            var horizontal = true;
            var vertical = true;
            foreach (var pos in positions)
            {
                var h = true;
                var v = true;
                var x = (int)Math.Round(pos.x);
                var y = (int)Math.Round(pos.y);
                var tile = instance.GetCellFromCoordinates(x, y);
                if (tile == null)
                {
                    if (y == maxY) v = false;
                    else h = false;
                }
                else
                {
                    if ((!tile.Tag.Equals("Empty")) && !tile.Tag.Equals(id.ToString()))
                    {
                        if (baseX != position.x) h = false;
                        else v = false;
                    }
                }


                if (!(!horizontal || !vertical))
                {
                    horizontal = h;
                    vertical = v;
                }
            }

            // Console.WriteLine(horizontal + " " + vertical);
            return new[]
            {
            horizontal,
            vertical
        };
        }
    }
}