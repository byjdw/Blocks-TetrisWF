using System;

namespace AS_Coursework.exceptions;

internal class InvalidPlayerUsernameException : Exception
{
    public InvalidPlayerUsernameException(string message) : base(message) {}
}