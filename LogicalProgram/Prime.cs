using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Prime
    {
        public void Nos()
        {
            int i,m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            int num = int.Parse(Console.ReadLine());
            m = num / 2;
            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(num+ " is not Prime number.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write(num+ " is Prime number.");
        }
    }
}
