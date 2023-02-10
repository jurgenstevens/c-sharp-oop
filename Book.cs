using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

