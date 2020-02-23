using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge
{
    class Logo
    {

        // Width of the logo inserted through the constructor shall be N.
        private int n;

        // Constructor for creating the logo with the width
        public Logo(int width)
        {
            setN(width);
        }

        // Setting the width to the class field and checking if it is within the range.
        public void setN(int width)
        {
            if(2 < width && width < 10000 && width % 2 != 0)
            {
                this.n = width;     
            }

            else
            {
                throw new IndexOutOfRangeException("The width (N) cannot be less than 3, more than 10 000 or even number!");
            }
        }

        // Method for drawing the logo.
        public void drawLogo()
        {

            int incr = 0;

                // Looping for the first upper part of the logo and printing the first half of the lines.
            for (int i = 0; i < (n + 1) / 2; i++)
            {

                // Using the formulas to calculate how many signs we are going to need

                Console.WriteLine(
                  new String('-', n - i)
                  + new String('*', n + incr)
                  + new String('-', n - incr)
                  + new String('*', n + incr)
                  + new String('-', n - i)
                  + new String('-', n - i)
                  + new String('*', n + incr)
                  + new String('-', n - incr)
                  + new String('*', n + incr)
                  + new String('-', n - i)
                  );

                /* Adding 2 to our additional variable in order to be able to increase
                 or reduce the signs we are using. */
                incr += 2;

            }

            incr = 0;

            // Looping through the second part of the logo and printing it.
            for (int i = 1; i <= (n + 1) / 2; i++)
            {

                Console.WriteLine(
                  new String('-', (n + 1) / 2 - i)
                  + new String('*', n)
                  + new String('-', 1 + incr)
                  + new String('*', n * 2 - 1 - incr)
                  + new String('-', 1 + incr)
                  + new String('*', n)
                  + new String('-', (n + 1) / 2 - i)
                  + new String('-', (n + 1) / 2 - i)
                  + new String('*', n)
                  + new String('-', 1 + incr)
                  + new String('*', n * 2 - 1 - incr)
                  + new String('-', 1 + incr)
                  + new String('*', n)
                  + new String('-', (n + 1) / 2 - i)
                  );
                incr += 2;

            }
        }
    }
}
