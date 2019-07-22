using System;

namespace Si.Criptografia
{
    public class EncryptionException : Exception
    {
        public EncryptionException(string message)
            : base(message)
        {
        }
    }
}
