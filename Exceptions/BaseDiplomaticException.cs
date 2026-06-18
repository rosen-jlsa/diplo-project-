using System;

namespace DiplomaticMission.Exceptions
{
    public abstract class BaseDiplomaticException : Exception
    {
        protected BaseDiplomaticException(string message) : base(message) { }
    }
}
