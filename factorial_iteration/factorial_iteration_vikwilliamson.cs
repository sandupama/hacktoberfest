/* Happy Hacktoberfest!!!
    Language: C#
    Author: Vik Williamson
    GitHub: https://github.com/vikwilliamson
 */

using System;

namespace factorial_iteration 
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate:
            Console.Write("What is the number you would like to calculate the factorial for?: ");
            int n = Int32.Parse(Console.ReadLine());
            int product = 1;

            if (n >= 0)
            {
                if (n > 0)
                { 
                    for (int i = n; i > 0; i--)
                    {
                        product *= i;
                    }
                }

                Console.WriteLine("The factorial of {0} is {1}", n, product);
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
                goto Calculate;
            }

            Console.ReadKey();
        }
    }
}