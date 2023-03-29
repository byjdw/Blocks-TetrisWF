using System;
using AS_Coursework.models;

namespace AS_Coursework.exceptions
{

internal class TileNotFoundException : Exception
{
    private Position position;

    public TileNotFoundException(string message, Position position) : base(message)
    {
        this.position = position;
    }
}
}