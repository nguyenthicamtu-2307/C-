using System;

namespace bai2
{
    class bai2
    {
        static void Main(string[] args)
        {
            int a253;
            Console.Write("Nhap so a: ");
            a253 = Convert.ToInt32(Console.ReadLine());
            switch (a253)
            {
                case 0:
                    {
                        Console.Write("không");
                        break;
                    }
                case 1:
                    Console.Write("một");
                    break;
                case 2:
                    Console.Write("Hai");
                    break;
                case 3:
                    Console.Write("Ba");
                    break;
                case 4:
                    Console.Write("Bốn");
                    break;
                case 5:
                    Console.Write("Năm");
                    break;
                case 6:
                    Console.Write("Sáu");
                    break;
                case 7:
                    Console.Write("Bảy");
                    break;
                case 8:
                    Console.Write("tám");
                    break;
                case 9:
                    Console.Write("chín");
                    break;
            }
            Console.ReadKey();
        }
      
    }
}
