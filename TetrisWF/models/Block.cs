using AS_Coursework.enums;
using AS_Coursework.game;
using AS_Coursework.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.models;

[Serializable]
public class Block
{
    // Block Configuration
    private int id;
    private int moves;
    private bool idle;
    private Image tile;
    private BlockType type;
    private readonly int maxR;
    private readonly int maxX;
    private readonly int maxY;

    // Position Tracking
    private int r;
    private readonly Position position;

    public int Id { get => id; set => id = value; }
    public BlockType Type { get => type; set => type = value; }
    public bool Idle { get => idle; set => idle = value; }

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
        switch (type) // Initialise block params;
        {
            case BlockType.LINE:
                tile = Resources.Board_Line; // Set block tile for rendering;
                position.y = -1; // This block is only 1 tile tall in default pos; custom start y set;
                maxR = 1; // Set maximum rotation value;
                break;
            case BlockType.SQUARE:
                tile = Resources.Board_Square; // Set block tile for rendering;
                maxR = 0; // Set maximum rotation value;
                break;
            case BlockType.Z:
                tile = Resources.Board_Z; // Set block tile for rendering;
                maxR = 1; // Set maximum rotation value;
                break;
            case BlockType.S:
                tile = Resources.Board_S; // Set block tile for rendering;
                maxR = 1; // Set maximum rotation value;
                break;
            case BlockType.L:
                tile = Resources.Board_L; // Set block tile for rendering;
                break;
            case BlockType.REVERSE_L:
                tile = Resources.Board_Reverse_L; // Set block tile for rendering;
                break;
            case BlockType.T:
                tile = Resources.Board_T; // Set block tile for rendering;
                break;
        }
        tile.Tag = type;
    }

    public void AdjustX(GameWindow instance, int adjX)
    {
        Console.WriteLine($"X: {position.x} => {position.x + adjX}");
        RenderNext(instance, position.x + adjX, position.y, r); // Calls RenderNext() with params causing the block to move horizontally.
    }

    public void Descend(GameWindow instance)
    {
        Console.WriteLine($"Y: {position.y} => {position.y + 1}");
        RenderNext(instance, position.x, position.y + 1, r); // Calls RenderNext() with params causing the block to descend by 1.
    }

    public void Rotate(GameWindow instance)
    {
        int newR = r + 1;
        if (newR > maxR) newR = 0;
        Console.Write($"R: {r} => {newR}");
        RenderNext(instance, position.x, position.y, newR);
    }

    private void RenderNext(GameWindow instance, float x, float y, int r)
    {
        List<Position> newBlock = GeneratePositions(x, y, r);
        bool[] validation = ValidatesTiles(instance, newBlock);
        bool h = validation[0]; // Valid horizontal move.
        bool v = validation[1]; // Valid vertical move.
        if (!v)
        {
            if (moves == 0) instance.GameOver();
            else idle = true;
        }
        if (!h) return;
        if (idle) return;

        if (y > 0)
        {
            List<Position> oldBlock = GeneratePositions(position.x, position.y, this.r);
            foreach (Position pos in oldBlock)
            {
                PictureBox oldTile = instance.GetTileFromCoordinates((int)Math.Round(pos.x), (int)Math.Round(pos.y));
                if (oldTile != null)
                {
                    oldTile.Image = Resources.Empty;
                    oldTile.Tag = "Empty";
                }
            }
        }
        else
        {
            for (int i = 0; i < maxX; i++)
            {
                PictureBox tile = instance.GetTileFromCoordinates(i, 0);
                if (tile != null)
                {
                    tile.Image = Properties.Resources.Empty;
                    tile.Tag = "Empty";
                }
            }
        }

        foreach (Position pos in newBlock)
        {
            PictureBox newTile = instance.GetTileFromCoordinates((int)Math.Round(pos.x),
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
        this.moves += 1;
    }

    public void ForceRender(GameWindow instance)
    {
        List<Position> newBlock = GeneratePositions(position.x, position.y, this.r);
        foreach (Position pos in newBlock)
        {
            PictureBox newTile = instance.GetTileFromCoordinates((int)Math.Round(pos.x),
                                                                 (int)Math.Round(pos.y));
            newTile.Image = tile;
            newTile.Tag = id.ToString();
        }
    }

    public void Hide(GameWindow instance)
    {
        if (position.y > 0)
        {
            List<Position> oldBlock = GeneratePositions(position.x, position.y, this.r);
            foreach (Position pos in oldBlock)
            {
                PictureBox oldTile = instance.GetTileFromCoordinates((int)Math.Round(pos.x), (int)Math.Round(pos.y));
                if (oldTile != null)
                {
                    oldTile.Image = Resources.Empty;
                    oldTile.Tag = "Empty";
                }
            }
        }
        else
        {
            for (int i = 0; i < maxX; i++)
            {
                PictureBox tile = instance.GetTileFromCoordinates(i, 0);
                tile.Image = Properties.Resources.Empty;
                tile.Tag = "Empty";
            }
        }
    }

    private List<Position> GeneratePositions(float row, float column, int r)
    {
        List<Position> tilePositions = new List<Position>();
        int x = (int)row;



        int y = (int)column;
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

    private bool[] ValidatesTiles(GameWindow instance, List<Position> positions)
    {
        int baseX = (int)Math.Round(positions[0].x);
        int baseY = (int)Math.Round(positions[0].y);
        bool horizontal = true;
        bool vertical = true;
        foreach (Position pos in positions)
        {
            bool h = true;
            bool v = true;
            int x = (int)Math.Round(pos.x);
            int y = (int)Math.Round(pos.y);
            PictureBox tile = instance.GetTileFromCoordinates(x, y);
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




        //foreach (Position tilePosition in positions)
        //{
        //    int x = (int)Math.Round(tilePosition.x);
        //    int y = (int)Math.Round(tilePosition.y);
        //    try
        //    {
        //        PictureBox tile = instance.GetTileFromCoordinates(x, y);
        //        if (tile != null)
        //        {
        //            if (
        //                !tile.Tag.Equals("Empty") &&
        //                !tile.Tag.Equals(id.ToString())
        //            )
        //            {
        //                Console.WriteLine($"Tile @ [{x},{y}] is NOT Valid.");
        //                if (positions[0].x != position.x)
        //                    horizontal = false;
        //                else
        //                    vertical = false;
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Tile @ [{x},{y}] is Valid.");
        //            }
        //        }
        //        else
        //        {
        //            if (y == maxY)
        //            {
        //                Console.WriteLine($"Tile @ [{x},{y}] is NOT Valid.");
        //                vertical = false;
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Tile @ [{x},{y}] is NOT Valid.");
        //                horizontal = false;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        Console.WriteLine($"Tile @ [{x},{y}] out of bounds!");
        //        horizontal = false;
        //    }
        //}
        Console.WriteLine(horizontal + " " + vertical);
        return new[]
        {
            horizontal,
            vertical
        };
    }

    public override string ToString()
    {
        return $"BLOCK: Type {type.ToString()}, Id {id}, Moves {moves}, Idle {idle}, X: {position.x}, Y: {position.y}, Dist to MaxY: {maxY - 1 - position.y}";
    }
}