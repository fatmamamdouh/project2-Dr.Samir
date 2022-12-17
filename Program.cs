using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Dr.Samir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter frist number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            int y = int.Parse(Console.ReadLine());
            int sum;
            for (int i = x; i <= y; i++)
            {
                sum = 0;
               
                for(int j = 1; j<=i/2; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                        
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(sum);

                }

            }
        }
    }
}
