using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Reverse
    {
        public void Nos()
        {
            int num, reverse = 0, rem;
            Console.WriteLine("Enter a number to reverse: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reversed Number: " + reverse);
        }
    }
}
