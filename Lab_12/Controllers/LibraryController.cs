using System;
using System.Collections.Generic;
using System.Text;
using Lab_7.Exceptions;
using Laba_7.Models;

namespace Laba_7.Controllers
{
   public class LibraryController
    {
        Library _library;
        public LibraryController(Library library)
        {
            _library = library;
        }

        public LibraryController()
        {
           // _library = new Library();
        }

        public void FillLibrary()
        {
            
            Textbook myBook = new Textbook();
            myBook.Age = 1215;
            myBook.NameOfBook = "Alaverdi";
            myBook.Price = 3.55;
            myBook.Subject = "Mathematic";

            Journal myJournal = new Journal();
            myJournal.Age = 1815;
            myJournal.Price = 50;
            myJournal.Period = "Monthly";

            Magazine myMagazine = new Magazine();
            myMagazine.Age = 2015;
            myMagazine.Theme = "News";

            #region a
            //bool b = MyBook is Print_Edition;
            //Print_Edition d = MyBook as Print_Edition;
            //Console.WriteLine($"{b} - {d}");
            //bool x = MyJournal is IPerson;
            //IPerson y = MyJournal as IPerson;
            //Console.WriteLine($"{x} - {y}");
            //Console.WriteLine();
            //Console.WriteLine($"{MyMagazine.ToString()}");
            //Printer MyPrint = new Printer();
            //Console.WriteLine();
            //object[] mas = { MyJournal, MyMagazine, MyBook };
            //for (int i = 0; i < mas.Length; i++)
            //    Console.WriteLine($"{MyPrint.IAmPrinting(mas[i] as Print_Edition)}");
            #endregion

            if(_library == null)
            {
                _library = new Library();
            }
            _library.Add(myBook);
            _library.Add(myJournal);
            _library.Add(myMagazine);
        }

        public void PrintLibrary()
        {
            try
            {
                _library.PrintInfo();
            }
            catch(NullReferenceException)
            {
                throw new LibraryIsEmptyException("Library is empty, nothing to print sorry!");
            }     
        }
        public void CountOfTextBooks()
        {
            _library.CountOfTextBooks();
        }

        public void PrintPriceOfBooks()
        {
            _library.PriceOfBooks();
        }

    }
}
