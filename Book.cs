using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OOP;

namespace OOP
{
	public class Book
	{
			public string title;
			public string author;
			public int pages;

		// this is the class' constructor
		public Book(string aTitle, string aAuthor, int aPages )
		{
			title = aTitle;
			author = aAuthor;
			pages = aPages;
			Console.WriteLine(title);
			Console.WriteLine(author);
			Console.WriteLine(pages);
		}
	}
}

// SECTION PRACTICE
//static void Main(string[] args)
//{
//    Book book1 = new Book("Harry Potter", "JK Rowling", 400);
//    //book1.title = "Harry Potter";
//    //book1.author = "JK Rowling";
//    //book1.pages = 400;

//    Book book2 = new Book("Lord of the Rings", "JRR Tolkein", 700);
//    //book2.title = "Lord of the Rings";
//    //book2.author = "JRR Tolkein";
//    //book2.pages = 700;

//    book2.title = "The Hobbit";
//    Console.WriteLine(book2.title);

//    Console.ReadLine();
//}

