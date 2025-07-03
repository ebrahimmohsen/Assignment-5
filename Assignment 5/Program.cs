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
            //Caller’s original variable never changes.

            //By reference : A reference to the caller’s variable is passed; the method works with the original storage.
            //Changes inside the method reflect outside(except in, which is read‑only).
            #endregion

            #region Q2 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            static void ValueDemo()
            {
                int a = 10, b = 10;

                IncrementByValue(a);   
                IncrementByRef(ref b);  

                Console.WriteLine($"a = {a}"); 
                Console.WriteLine($"b = {b}"); 
            }

            static void IncrementByValue(int x) => x++;            
            static void IncrementByRef(ref int x) => x++;
            #endregion
        }
    }
}
