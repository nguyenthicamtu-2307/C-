using System;

namespace bai66

{
    class Program
    {
        static void Main(string[] args)
        {
            int maxpos, minpos;
            maxpos = minpos = 0;
            Random r = new Random();
            int n = Int32.Parse(Console.ReadLine());
            int n2 = n;
            int k, i;
            int[] arr = new int[n];
            for ( i = 0; i < n; i++)
            {
                arr[i] = r.Next(-100, 100);
            }
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for ( i = 1; i < n; ++i)
            {
                if (arr[i] < arr[minpos]) minpos = i;
                if (arr[i] > arr[maxpos]) maxpos = i;
            }
            Console.Write($"\n max = {arr[maxpos]}");
            Console.Write($"\n min = {arr[minpos]} \n");
         
            for ( k =  i = maxpos + 1; i < n; ++i)
            {
                if (arr[i] != arr[maxpos])
                {
                    arr[k++] = arr[i];
                    n = k;
                }
                 
            }

            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");


            Console.ReadKey();
        }
    }
}
