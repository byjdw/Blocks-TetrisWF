using System;

namespace AS_Coursework.exceptions
{
    internal class InvalidPlayerException : Exception
    {
        public InvalidPlayerException(string message) : base(message)
        {
        }
    }
}