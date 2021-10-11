using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs
{
    class Prime_number
    {
        static void Main(string[] args)
        {


            int Num;
            Console.Write("Enter  the number :   ");
            Num = int.Parse(Console.ReadLine());


            int i = 2;
            for (i = 2; i <= Num / 2; i++)
            {


                int Check = (Num % i);

                if (Check == 0)
                {
                    Console.WriteLine(+Num + " :is not a  prime number");
                    break;
                }
                else if (Check != 0)
                {
                    Console.WriteLine(+Num + ":is a prime number");
                    break;
                }

            }

            Console.ReadLine();

        }
    }
}
