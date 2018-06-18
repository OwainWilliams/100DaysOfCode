using System;
using ConsoleApp1;
using ConsoleApp1.Maths;

namespace ConsoleApp1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Williams";
            person.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(2, 4);




            Console.WriteLine(result);
        }
    }
}
