using System;

namespace LibraryManagerBussiness.Exception
{
    [Serializable]
    public sealed class InvalidAccountRegisterException : SystemException
    {
        public InvalidAccountRegisterException()
        {
        }
        public InvalidAccountRegisterException(string message) : base(message)
        {
        }

    }
}
