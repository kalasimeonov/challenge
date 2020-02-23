using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            // Reading from the console the width we are going to use for the logo (width == n).
            Console.WriteLine("Please enter the width within the following range: 2 < N < 10000, and should be an odd number");
            String input = Console.ReadLine();

            // Parsing the input we received to integer.
            int n = int.Parse(input);

            try
            { 
                // Creating new object of the logo class.
                Logo testLogo = new Logo(n);

                // Calling the drawLogo() method to print the logo of the object.
                testLogo.drawLogo();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Start the program over as the width (N) value was not within the range!");
            }
        }
    }
}
