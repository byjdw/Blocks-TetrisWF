using System;

namespace AS_Coursework.exceptions;

internal class InvalidLoginException : Exception
{
    public InvalidLoginException(string message) : base(message) { }
}