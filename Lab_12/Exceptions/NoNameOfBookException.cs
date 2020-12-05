using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Lab_7.Exceptions
{
    public class NoNameOfBookException : Exception
    {
        public NoNameOfBookException(String message) : base(message)
        {

        }
    }
}
