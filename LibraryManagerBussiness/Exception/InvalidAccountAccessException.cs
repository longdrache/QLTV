using System;

namespace LibraryManagerBussiness.Exception
{
    [Serializable]
    public sealed class InvalidAccountAccessException : SystemException
    {
        public InvalidAccountAccessException()
        {
        }

        public InvalidAccountAccessException(string message) : base(message)
        {
        }
    }
}
