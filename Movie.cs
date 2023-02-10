using System;
namespace OOP
{
	public class Movie
	{
		public string title;
		public string director;
		// INCLUDE GETTERS AND SETTERS FOR PRIVATE ATTRIBUTES
		private string rating;

		public Movie(string aTitle, string aDirector, string aRating)
		{
			title = aTitle;
			director = aDirector;
			rating = aRating;
		}

		public string Rating
		{
			get { return rating;  }
			set {
				if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
				{
					rating = value;
				}
				else
				{
					rating = "NR";
				}
			}
		}
	}
}

