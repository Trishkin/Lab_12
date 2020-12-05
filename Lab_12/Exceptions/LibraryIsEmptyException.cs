using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7.Exceptions
{
    public class LibraryIsEmptyException : NullReferenceException
    {

      public  LibraryIsEmptyException(String message):base(message)
        {
            
        }

    }
}
