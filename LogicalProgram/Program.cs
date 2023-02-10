using System;

namespace LogicalProgram
{
    internal class Programfd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Basic Core Programs  -----");
            Console.Write("1. Fibonacci Series\n2. Perfect No\n3. Prime No\n4. Reversing a No\n5. Coupon No\n6. Exit\nChoose option to perform:");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your choice is: " + option + "\n");
            switch (option)
            {
                case 1:
                    Console.WriteLine("----->  Fibonacci Series  <-----");
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Series();
                    break;
                case 2:
                    Console.WriteLine("\n-----> Perfect Number  <-----");
                    Perfect perfect = new Perfect();
                    perfect.Nos();
                    break;
                case 3:
                    Console.WriteLine("\n----->  Prime Numbers  <-----");
                    Prime prime = new Prime();
                    prime.Nos();
                    break;
                case 4:
                    Console.WriteLine("\n----->  Reverse a Number  <-----");
                    Reverse reverse = new Reverse();
                    reverse.Nos();
                    break;
                case 5:
                    Console.WriteLine("----->  Coupon No  <-----");
                    Coupon coupon = new Coupon();
                    coupon.No();
                    break;
                default:
                    Console.WriteLine("Closing the program");
                    break;
            }
        }
    }
}