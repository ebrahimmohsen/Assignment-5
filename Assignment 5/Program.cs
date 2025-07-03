using System.Numerics;
using System.Reflection;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //By value :A copy of the value‑type( int, double, struct) is placed on the stack and given to the method.
            //Caller’s original variable never changes..

            //By reference : A reference to the caller’s variable is passed; the method works with the original storage.
            //Changes inside the method reflect outside(except in, which is read‑only).
            #endregion


            #region Q2 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            static (int sum, int diff) SumAndSubtract(int x, int y, int z, int w)
            {
                int sum = x + y;
                int diff = z - w;
                return (sum, diff);

            }
            #endregion


            #region Q3 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            static int SumDigits(int n)
            {
                n = Math.Abs(n);
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                return sum;
            }

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"The sum of the digits of the number {num} is: {SumDigits(num)}");
            #endregion

            #region Q4 Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            static bool IsPrime(int n)
            {
                if (n < 2) return false;
                if (n == 2) return true;
                if (n % 2 == 0) return false;

                for (int i = 3; i * i <= n; i += 2)
                    if (n % i == 0) return false;
                return true;
            }
            #endregion


        }
    }
}
