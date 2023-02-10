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
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "JRR Tolkein";
            book2.pages = 700;

            Console.ReadLine();
        }
    }
}