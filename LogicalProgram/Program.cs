using System;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Logical Programming  -----\n----->  Fibonacci Series  <-----");
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.Series();
        }
    }
}