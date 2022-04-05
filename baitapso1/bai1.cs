using System;

namespace baitapcoban1
{
    class bai1
    {
        static void Main(string[] args)
        {
            int a253;
            Console.Write("Nhap so a = ");
            a253 = int.Parse(Console.ReadLine());
            if (a253 > 0)
                Console.WriteLine($"{a253} la so nguyen duong");
            if (a253 < 0)
                Console.WriteLine($"{a253} la so nguyen am");
            Console.ReadKey();
        }
    }
}
