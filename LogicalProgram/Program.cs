using System;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Logical Programming  -----\n----->  Prime Numbers  <-----");
            Prime prime = new Prime();
            prime.Nos();
        }
    }
}