using AS_Coursework.enums;
using AS_Coursework.forms.game;
using AS_Coursework.io;
using AS_Coursework.io.audio;
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
            r = 0;
            moves = 0;
            maxR = 3;
            position = new Position { x = 4, y = 0 };

            switch (type) // Initialise block params for blocks that require it;
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

            tile = GameIOManager.Tiles[(int)type];
            tile.Tag = type.ToString();
        }

        public int Id { get => id; set => id = value; }
        public BlockType Type { get => type; set => type = value; }
        public bool Idle { get => idle; set => idle = value; }
        public Position Pos { get => position; set => position = value; }

        /// <summary>
        /// Moves the block horizontally by the specified amount.
        /// </summary>
        /// <param name="gameWindow">The game window instance.</param>
        /// <param name="adjustment">The amount to adjust the X position by.</param>
        public void MoveHorizontally(GameWindow gameWindow, int adjustment)
        {
            RenderNextFrame(gameWindow, position.x + adjustment, position.y, r);
        }

        /// <summary>
        /// Moves the block down by one position.
        /// </summary>
        /// <param name="gameWindow">The game window instance.</param>
        public void MoveDown(GameWindow gameWindow)
        {
            RenderNextFrame(gameWindow, position.x, position.y + 1, r);
        }

        /// <summary>
        /// Rotates the block clockwise by 90 degrees.
        /// </summary>
        /// <param name="gameWindow">The game window instance.</param>
        public void RotateClockwise(GameWindow gameWindow)
        {
            int newRotation = (r + 1) % (maxR + 1);
            RenderNextFrame(gameWindow, position.x, position.y, newRotation);
        }

        /// <summary>
        /// Renders the next frame of the block's movement.
        /// </summary>
        /// <param name="gameWindow">The game window instance.</param>
        /// <param name="x">The X position of the block.</param>
        /// <param name="y">The Y position of the block.</param>
        /// <param name="rotation">The rotation of the block.</param>
        private void RenderNextFrame(GameWindow gameWindow, float x, float y, int rotation)
        {
            var newBlockPositions = GeneratePositions(x, y, rotation);
            var positionValidation = ValidateTiles(gameWindow, newBlockPositions);
            if (!positionValidation[0])
            {
                return;
            }

            if (!positionValidation[1])
            {
                if (moves == 0)
                {
                    gameWindow.GameOver();
                }
                else
                {
                    idle = true;
                }
            }

            if (idle)
            {
                return;
            }

            gameWindow.SuspendLayout();
            Hide(gameWindow);

            // Calculate the ghost block positions.

            List<Position> ghostBlockPositions = GenerateGhostBlockPositions(gameWindow, x, y, rotation);
            foreach (var pos in ghostBlockPositions) RenderTile(gameWindow, pos.x, pos.y, Resources.Ghost, id.ToString());
            foreach (var pos in newBlockPositions) RenderTile(gameWindow, pos.x, pos.y, tile, id.ToString());

            gameWindow.ResumeLayout(true);

            if (y == position.y)
            {
                if (rotation == this.r)
                {
                    AudioController.PlaySoundEffect("move");
                }
                else
                {
                    AudioController.PlaySoundEffect("rotate");
                }
            }

            position.x = x;
            position.y = y;
            this.r = rotation;
            moves++;
        }

    /// <summary>
    /// An overload function of RenderTile that fetches a cell from the game window using the x and y coordinates of the tile.
    /// </summary>
    /// <param name="GameWindow">A class representing the game window or screen where the tiles will be
    /// rendered.</param>
    /// <param name="x">The x-coordinate of the tile's position on the game window.</param>
    /// <param name="y">The y-coordinate of the tile's position on the game window.</param>
    /// <param name="Image">The image to be rendered on the tile.</param>
    /// <param name="tag">The tag parameter is a string that is used to identify the tile being rendered. It
    /// can be used to associate additional information or behavior with the tile.</param>
        private void RenderTile(GameWindow gameWindow, float x, float y, Image tile, string tag)
        {
            PictureBox cell = gameWindow.GetCellFromCoordinates((int)Math.Round(x), (int)Math.Round(y));
            RenderTile(cell, tile, tag);
        }


        /// <summary>
        /// This function sets the image and tag of a game board cell.
        /// </summary>
        /// <param name="PictureBox">A Windows Forms control that displays an image.</param>
        /// <param name="Image">The image to be rendered on the Cell.</param>
        /// <param name="tag">The tag parameter is a string that can be used to store additional information
        /// about the tile being rendered. It can be used to identify the Block Type of the tile.</param>
        private void RenderTile(PictureBox cell, Image tile, string tag)
        {
            if (cell != null)
            {
                cell.Image = tile;
                cell.Tag = tag;
            }
        }

        /// <summary>
        /// This function generates the positions of a ghost block in a Tetris game.
        /// </summary>
        /// <param name="GameWindow">It is an object that represents the game window or screen where the game is
        /// being played. It is used to validate the positions of the ghost block and ensure that it does not
        /// overlap with any existing blocks on the screen or go out of bounds..</param>
        /// <param name="x">The x-coordinate of the block's position.</param>
        /// <param name="y">The y-coordinate of the block's position.</param>
        /// <param name="rotation">The rotation of the block, in degrees.</param>
        /// <returns>
        /// The method returns a List of Position objects representing the positions of the ghost block.
        /// </returns>
        private List<Position> GenerateGhostBlockPositions(GameWindow gameWindow, float x, float y, int rotation)
        {
            int row = (int)Math.Round(x);
            int column = (int)Math.Round(y);
            List<Position> positions = GeneratePositions(row, column, rotation);

            bool ValidGhostPlacement = true;
            while (ValidGhostPlacement)
            {
                List<Position> newGhostBlock = GeneratePositions(x, positions[0].y + 1, rotation);
                bool[] ValidGhostBlock = ValidateTiles(gameWindow, newGhostBlock);
                if (ValidGhostBlock[0] && ValidGhostBlock[1]) positions = newGhostBlock;
                else ValidGhostPlacement = false;
            }

            return positions;
        }

        /// <summary>
        ///     It hides the block by replacing its tiles with empty tiles
        /// </summary> 
        /// <param name="GameWindow">The gameWindow of the game window.</param>
        public void Hide(GameWindow gameWindow)
        {
            gameWindow.SuspendLayout();
            List<PictureBox> OccupiedCells = new List<PictureBox>();
            foreach (PictureBox BoardCell in gameWindow.Cells)
                if (Convert.ToString(BoardCell.Tag) == id.ToString()) OccupiedCells.Add(BoardCell);
            foreach (PictureBox Cell in OccupiedCells) RenderTile(Cell, Resources.Empty, "Empty");
            gameWindow.ResumeLayout(true);

        }

        /// <summary>
        ///     It takes a row, column, and rotation, and returns a list of positions that represent the block in
        ///     that state.
        /// </summary>
        /// <param name="row">the row of the cell</param>
        /// <param name="column">the column of the cell</param>
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
        /// Validates if the tiles are valid for the current piece's next movement
        /// </summary>
        /// <param name="gameWindow">The game window object</param>
        /// <param name="positions">A list of positions that the piece is going to be occupying</param>
        /// <returns>A boolean array indicating if the movement is valid horizontally and vertically</returns>
        private bool[] ValidateTiles(GameWindow gameWindow, List<Position> positions)
        {
            int baseX = (int)Math.Round(positions[0].x);
            bool horizontal = true;
            bool vertical = true;

            foreach (Position pos in positions)
            {
                bool h = true;
                bool v = true;
                int x = (int)Math.Round(pos.x);
                int y = (int)Math.Round(pos.y);
                var cell = gameWindow.GetCellFromCoordinates(x, y);

                if (cell == null)
                {
                    if (y == maxY)
                    {
                        v = false;
                    }
                    else
                    {
                        h = false;
                    }
                }
                else if (!cell.Tag.Equals("Empty") && !cell.Tag.Equals(id.ToString()))
                {
                    if (baseX != position.x)
                    {
                        h = false;
                    }
                    else
                    {
                        v = false;
                    }
                }

                horizontal &= h;
                vertical &= v;
            }

            return new bool[] { horizontal, vertical };
        }
    }
}