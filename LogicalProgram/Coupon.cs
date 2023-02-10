using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class Coupon
    {
        public void No()
        {
            Console.Write("No of coupons want to generate:   ");
            int coup = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int[] discoupon = new int[coup];
            Random r = new Random();
            int count = 0;

            while (i < coup)
            {
                int random = r.Next(0, 100);
                Console.WriteLine(random);
                count++;
                if (discoupon.Contains(random))
                    //skip that particular iteration
                    continue;
                else
                    discoupon[i] = random;
                i++;
            }
            //Console.WriteLine("Generated coupon's in:{0}\n", coup);
            Console.WriteLine("Lucky withdrawl coupon numbers are: ");
            foreach (int coupon in discoupon)
            {
                Console.Write(coupon + " ");
            }
            
        }
    }
}
