using System;

namespace bai60
{
    class Program
    {

        static void Main(string[] args)
        {
            Random r = new Random();
            int n = Int32.Parse(Console.ReadLine());
            int n2 = n;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(-100, 100);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\n");

            perfectShuffle(arr);

            Console.ReadKey();
        }

        static void perfectShuffle(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Console.Write(arr[i] + " ");
                Console.Write(arr[arr.Length / 2 + i] + " ");
            }
        }
    }
}
