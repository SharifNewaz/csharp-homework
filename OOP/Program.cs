using System;
using OOP;

namespace Program{

    class OOP
    {
        public static void Main()
        {
            Person student = new Student();
            student.LogInformation();
            student.PrintLogInformation();

            Person teacher = new Instructor();
            teacher.LogInformation();
            teacher.PrintLogInformation();




            Console.ReadLine();
        }
    }     
}