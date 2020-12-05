using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7.Controllers
{
    public class PriceShouldBePositiveException : ArgumentOutOfRangeException
    {
        public PriceShouldBePositiveException(String message) : base(message)
        {

        }
    }
}
