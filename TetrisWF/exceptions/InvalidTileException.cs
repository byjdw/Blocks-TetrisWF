using AS_Coursework.models;
using System;

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