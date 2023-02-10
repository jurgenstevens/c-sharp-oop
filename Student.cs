using System;
using OOP;

namespace OOP
{
	public class Student
	{
		public string name;
		public string major;
		public double gpa;

		public Student(string aName, string aMajor, double aGpa)
		{
			name = aName;
			major = aMajor;
			gpa = aGpa;
		}

		// Method that checks if student has honors
		public bool hasHonors()
		{
			if (gpa >= 3.5) {
				return true;
			}
			return false;
		}
	}
}

// SECTION PRACTICE
//static void Main(string[] args)
//{
//    Student student1 = new Student("Jim", "Business", 2.8);
//    Student student2 = new Student("Pam", "Art", 3.6);

//    Console.WriteLine(student1.hasHonors());
//    Console.WriteLine(student2.hasHonors());

//    Console.ReadLine();
//}