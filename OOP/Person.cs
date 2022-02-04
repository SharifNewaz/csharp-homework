using System;

namespace OOP
{
	abstract public class Person
	{
        public String Name { get; set; }
        public int Age { get; set; }

        public abstract void LogInformation();
        public abstract void PrintLogInformation();
    }

	public class Instructor : Person
    {
        private decimal Salary { get; set; }
        private string Benefits { get; set; }

        public override void LogInformation()
        {
            Console.Write("Enter Name = ");
            Name = Console.ReadLine();

            Console.Write("Enter Age = ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Salary = ");
            Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write($"Enter Benefits = ");
            Benefits = Console.ReadLine();
        }

        public override void PrintLogInformation()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
            Console.WriteLine($"Salary = {Salary}");
            Console.WriteLine($"Benefits = {Benefits}");
        }

        public void Teaching()
        {
            Console.WriteLine("I'm teaching.");
        }

    }

    public class Student : Person
    {
        private int StudentNum { get; set; }

        public override void LogInformation()
        {
            Console.Write("Enter Name = ");
            Name = Console.ReadLine();

            Console.Write("Enter Age = ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Number = ");
            StudentNum = Convert.ToInt32(Console.ReadLine());
        }

        public override void PrintLogInformation()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
            Console.WriteLine($"Student Number = {StudentNum}");
        }

        public void study()
        {
            Console.WriteLine("I am studying.");
        }
    }
}

