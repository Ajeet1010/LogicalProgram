using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Perfect
    {
        public void Nos()
        {
            int number, sum = 0, i;
            Console.Write("Enter the Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum = sum + i;
            }
            if (sum == number)
                Console.WriteLine("Entered number " + number + " is a perfect number");
            else
                Console.WriteLine("Entered number " + number + " is not a perfect number");
        }
    }
}
