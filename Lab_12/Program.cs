using System;
using Lab_7.Controllers;
using Lab_7.Exceptions;
using Laba_7.Controllers;
using System.Diagnostics;
using Lab_12;
using Laba_7.Models;
using System.IO;

namespace Laba_7
{
  
    public interface IPerson
    {
        bool Person();

    }
  
  
    partial class Class1
    { 
    public void ICanRun()
        { 
            Console.WriteLine($"I Run");
        }
    }

     

    class Program
    {

        static void Main(string[] args)
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


            //Magazine myMagazine = new Magazine();
            //myMagazine.Age = 2015;
            //myMagazine.Theme = "News";

            Reflector.First("Laba_7.Journal");
            Reflector.First("Laba_7.Journal");
            Reflector.GetNameOfMethods("Laba_7.Journal", "System.String");
            Reflector.GetNameOfMethods("Laba_7.Journal", "System.String");

            string path = @"D:\OOP\Lab_12\param.txt";
            string[] parms = { "", "" };
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    parms[0] = sr.ReadLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Random rnd = new Random();
            parms[1] = Convert.ToString(rnd.Next(0, 20));
            Reflector.Invoke(myBook, "ForLab", parms);

            Textbook myBook2 = Reflector.Crate<Textbook>(typeof(Textbook));
            myBook2.Age = 1823;
            Console.WriteLine(myBook2.ToString());
        }
    }
}

