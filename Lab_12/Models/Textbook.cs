using System;
using System.Collections.Generic;
using System.Text;
using Laba_7.Book;

namespace Laba_7
{
    public class Textbook : PrintEdition, IBook
    {
        //new public string Author = "Me", Publisher = "My friend";
       // public readonly string Type = "Textbook";
        public string Subject { get; set; }
        public override bool electronic_analogue()
        { return true; }
        bool IBook.electronic_analogue()
        { return false; }
        //bool IPerson.Person()
        //{
        //    return false;
        //}
        public override string ToString()
        {
            return ($"Type = {GetType().Name}, Author = {Author}, Publisher = {Publisher}, Name = {NameOfBook}, Age = {Age}, Price = {Price}, Subject = {Subject}");

        }
    }
}
