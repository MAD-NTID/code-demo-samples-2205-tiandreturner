using System;

namespace LambdasRule
{
    class Program
    {
		delegate bool IsYoungerThan(Student stud, int youngAge);
		public static void Main()
		{

            //IsYoungerThan isYoungerThan = delegate (Student s, int age)
            //{
            //    return s.Age < age;
            //};

            IsYoungerThan someMethod = (s, youngAge) => s.Age < youngAge;

			Student stud = new Student() { Age = 25 };

			

			Console.WriteLine(someMethod(stud, 26));
		}

		//public bool someMethod(Student s, int youngAge)
		//{
		//	return s.Age < youngAge;
		//}
	}

	class Student
    {
		private int age;
        public int Age { get => age; set => age = value; }

        private int myLuckyNumber;

        public int LuckyNumber
        {
            get => myLuckyNumber;
            set => myLuckyNumber = value;
        }


        //public int Age{
        //get{ return age; }
        //set{ age = value; }
        //}
    }
}
