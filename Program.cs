using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OOP;
using static System.Net.Mime.MediaTypeNames;

namespace ControlFlow
{
    class ControlFlow
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adamn Adamson", "PG");

            Console.WriteLine(avengers.rating);
            Console.ReadLine();
        }
    }
}