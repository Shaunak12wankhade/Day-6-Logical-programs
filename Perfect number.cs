using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs
{
    class Perfect_number
    {
        static void Main(string[] args)
        {
           

                int Num;
                Console.Write("Enter the Number : ");
                Num = int.Parse(Console.ReadLine());

                int i = 1;
                int sum = 0;

                while (i <= Num / 2)
                {
                    int Output = (Num % i);
                    if (Output == 0)
                    {
                        sum = sum + i;



                    }
                    i++;
                }
                if (Num == sum)
                {
                    Console.WriteLine(+Num + ":is a perfect Number");

                }
                else
                {
                    Console.WriteLine(+Num + ":is not a perfect Number");

                }


                Console.ReadLine();


            
        }
    }
}
