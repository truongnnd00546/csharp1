using System;

namespace YangYesterday.utility
{
    public class TransactionException : Exception
    {
        public TransactionException(string message) : base(message)
        {
        }
    }
}