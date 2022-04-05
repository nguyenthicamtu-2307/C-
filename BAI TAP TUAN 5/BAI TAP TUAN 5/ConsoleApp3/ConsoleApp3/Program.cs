using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu cao cua tam giac: ");
            int n = int.Parse(Console.ReadLine());

            int c = n - 2;
            int d = 3 + 2 * c;

            //for(int i=1; i<=h; i++)
            //{
            //    for(int j=1; j<=d; j++)
            //    {

            //    }
            //}

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
