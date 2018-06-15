using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A demo about Operators

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            
            // Add
            Console.WriteLine(a+b);
            
            // Subtract
            Console.WriteLine(a-b);
            
            // Multiply
            Console.WriteLine(a*b);
            
            // Divide
            Console.WriteLine((float)a/(float)b);

            // Precedence of operators
            Console.WriteLine((a + b) * c);

            // Comparison operators
            Console.WriteLine(a > b);

            // Logicial operators
            Console.WriteLine(c > b && c > a);

            
             
        }
    }
}
