using System;

namespace AS_Coursework.exceptions;

internal class TileNotFoundException : Exception
{
    public TileNotFoundException(string message) : base(message)
    {
    }
}