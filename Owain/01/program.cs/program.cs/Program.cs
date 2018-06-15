using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ctrl + Shift + B to compile (short cut key)
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A'; //single quotes for characters
            string firstName = "Owain"; // strings use double quotes
            bool isWorking = true; // true or false

            /* alternatively, replace all above with var and let the compiler do the work
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            etc.
            */

            Console.WriteLine(number);
            //cw tab tab = snippet
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // "{0} {1}" is a format string, it uses the values after the comma.
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

           

        }
    }
}
