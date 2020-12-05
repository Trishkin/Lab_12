using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_7.Models
{
    public sealed class Magazine : PrintEdition//, IPerson
    {
        public string Theme { get; set; }
      
        public override bool electronic_analogue()
        { return true; }
        public override string ToString()
        {

           return($"Type = {GetType().Name}, Author = {Author}, Publisher = {Publisher}, Name = {NameOfBook}, Age = {Age}, Price = {Price}, Theme = {Theme}");

        }
    }
}
