using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_7
{
    public class Printer
    {
        public virtual void IAmPrinting(PrintEdition someobj)
        {
            // определите тип
            Console.WriteLine(someobj.GetType().Name);
            //вызовите ToString()
            someobj.ToString();         
        }
    }
}
