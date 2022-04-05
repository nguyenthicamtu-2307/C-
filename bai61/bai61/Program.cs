using System;

namespace bai61
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = Int32.Parse(Console.ReadLine());
            int n2 = n;
            int i,s;
            
            int[] arr = new int[n];
            for ( i = 0; i < n; i++)
            {
                arr[i] = r.Next(-100, 100);
            }
            for ( i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for(s = i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    s += arr[i];
                 
                }
              
            }
            Console.Write($"\n tong cac so nguyen duong la: {s}");
            Console.Write("\n nhap p: ");
            int p = Int32.Parse(Console.ReadLine());
            for (i = p + 1; i < n; ++i)
            {
                arr[i - 1] = arr[i];
                n--;
                Console.Write(arr[i]);
            }
              
            Console.Write("\n");
            Console.ReadKey();
        }

    }
}
