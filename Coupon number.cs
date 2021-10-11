using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs
{
    class Coupon_number
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Coupon Number Program");

            int Num;
            Console.Write("Enter the number :   ");
            Num = int.Parse(Console.ReadLine());


            int[] Numbers = new int[Num];  //creating an array for storing the numbers 


            int i;
            int count = 0;
            for (i = 1; i < Num; i++)
            {
                Random random = new Random();
                Numbers[i] = random.Next(1, Num + 1);


                bool isRepeated = false;
                for (int j = 0; j < i; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        isRepeated = true;
                        break;

                    }
                }
                if (!isRepeated)
                {
                    count++;
                }

            }

            Console.WriteLine("Random number should have distinct numbers :" + count);

            Console.ReadLine();



        }
    }
}
