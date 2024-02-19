using System;

public class UserAlreadyLoggedInToTheSystemOnOtherTabException : Exception
{
    public UserAlreadyLoggedInToTheSystemOnOtherTabException() : base()
    {
    }

    public UserAlreadyLoggedInToTheSystemOnOtherTabException(string message) : base(message)
    {
    }

    public UserAlreadyLoggedInToTheSystemOnOtherTabException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
