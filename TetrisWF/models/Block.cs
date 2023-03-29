using System;
using System.Collections.Generic;
using System.Drawing;
using AS_Coursework.enums;
using AS_Coursework.forms.game;
using AS_Coursework.forms;
using AS_Coursework.Properties;
using AS_Coursework.io;

namespace AS_Coursework.models
{

[Serializable]
public class Block
{
    private readonly int maxR;
    private readonly int maxX;

    private readonly int maxY;

    // Block Configuration
    private int id;
    private bool idle;
    private int moves;
    private Position position;

    // Position Tracking
    private int r;
    private Image tile;
    private BlockType type;

    public Block()
    {
    }

    public Block(int id, BlockType type, int maxX, int maxY)
    {
        this.id = id;
        this.type = type;
        this.maxX = maxX;
        this.maxY = maxY;
        position = new Position
        {
            x = 4,
            y = 0
        };
        r = 0;
        maxR = 3;
        tile = DataManager.Tiles[(int)type];
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
        Console.WriteLine($"X: {position.x} => {position.x + adjX}");
        RenderNext(instance, position.x + adjX, position.y,
            r); // Calls RenderNext() with params causing the block to move horizontally.
    }

    /// <summary>
    ///     It calls RenderNext() with params causing the block to descend by 1
    /// </summary>
    /// <param name="GameWindow">The instance of the game window.</param>
    public void Descend(GameWindow instance)
    {
        Console.WriteLine($"Y: {position.y} => {position.y + 1}");
        RenderNext(instance, position.x, position.y + 1,
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
        Console.Write($"R: {r} => {newR}");
        RenderNext(instance, position.x, position.y, newR);
    }

    /// <summary>
    ///     It renders the next block
    /// </summary>
    /// <param name="GameWindow">The instance of the game window.</param>
    /// <param name="x">The x position of the block.</param>
    /// <param name="y">The y-coordinate of the block.</param>
    /// <param name="r">Rotation</param>
    private void RenderNext(GameWindow instance, float x, float y, int r)
    {
        var newBlock = GeneratePositions(x, y, r);
        var validation = ValidatesTiles(instance, newBlock);
        var h = validation[0]; // Valid horizontal move.
        var v = validation[1]; // Valid vertical move.
        if (!v)
        {
            if (moves == 0) instance.GameOver();
            else idle = true;
        }

        if (!h) return;
        if (idle) return;

        if (y > 0)
        {
            var oldBlock = GeneratePositions(position.x, position.y, this.r);
            foreach (var pos in oldBlock)
            {
                var oldTile = instance.GetTileFromCoordinates((int)Math.Round(pos.x), (int)Math.Round(pos.y));
                if (oldTile != null)
                {
                    oldTile.Image = Resources.Empty;
                    oldTile.Tag = "Empty";
                }
            }
        }
        else
        {
            for (var i = 0; i < maxX; i++)
            {
                var tile = instance.GetTileFromCoordinates(i, 0);
                if (tile != null)
                {
                    tile.Image = Resources.Empty;
                    tile.Tag = "Empty";
                }
            }
        }

        foreach (var pos in newBlock)
        {
            var newTile = instance.GetTileFromCoordinates((int)Math.Round(pos.x),
                (int)Math.Round(pos.y));
            if (newTile != null)
            {
                newTile.Image = tile;
                newTile.Tag = id.ToString();
            }
        }

        position.x = x;
        position.y = y;
        this.r = r;
        moves += 1;
    }

    /// <summary>
    ///     It hides the block by replacing the tiles with empty tiles
    /// </summary>
    /// <param name="GameWindow">The instance of the game window.</param>
    public void Hide(GameWindow instance)
    {
        if (position.y > 0)
        {
            var oldBlock = GeneratePositions(position.x, position.y, r);
            foreach (var pos in oldBlock)
            {
                var oldTile = instance.GetTileFromCoordinates((int)Math.Round(pos.x), (int)Math.Round(pos.y));
                if (oldTile != null)
                {
                    oldTile.Image = Resources.Empty;
                    oldTile.Tag = "Empty";
                }
            }
        }
        else
        {
            for (var i = 0; i < maxX; i++)
            {
                var tile = instance.GetTileFromCoordinates(i, 0);
                tile.Image = Resources.Empty;
                tile.Tag = "Empty";
            }
        }
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
    private bool[] ValidatesTiles(GameWindow instance, List<Position> positions)
    {
        var baseX = (int)Math.Round(positions[0].x);
        var baseY = (int)Math.Round(positions[0].y);
        var horizontal = true;
        var vertical = true;
        foreach (var pos in positions)
        {
            var h = true;
            var v = true;
            var x = (int)Math.Round(pos.x);
            var y = (int)Math.Round(pos.y);
            var tile = instance.GetTileFromCoordinates(x, y);
            if (tile == null)
            {
                if (y == maxY) v = false;
                else h = false;
            }
            else
            {
                Console.WriteLine($"TILE: Tag {tile.Tag}");
                if (!tile.Tag.Equals("Empty") && !tile.Tag.Equals(id.ToString()))
                {
                    if (baseX != position.x) h = false;
                    else v = false;
                }
            }

            if (!v || !h) Console.WriteLine($"Tile @ [{x},{y}] is NOT Valid.");
            else Console.WriteLine($"Tile @ [{x},{y}] is Valid.");
            if (!(!horizontal || !vertical))
            {
                horizontal = h;
                vertical = v;
            }
        }

        Console.WriteLine(horizontal + " " + vertical);
        return new[]
        {
            horizontal,
            vertical
        };
    }

    /// <summary>
    ///     It returns a string that contains the block's type, id, moves, idle, x, y, and distance to the maxY
    /// </summary>
    /// <returns>
    ///     The parameters of the block.
    /// </returns>
    public override string ToString()
    {
        return
            $"BLOCK: Type {type.ToString()}, Id {id}, Moves {moves}, Idle {idle}, X: {position.x}, Y: {position.y}, Dist to MaxY: {maxY - 1 - position.y}";
    }
}
}