using System;
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

