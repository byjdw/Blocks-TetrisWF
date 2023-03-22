using System;

namespace AS_Coursework.exceptions;

internal class TileNotFoundException : Exception
{
    Position position;
    public TileNotFoundException(String message, Position position) : base(message)
    {
        this.position = position;
    }
}