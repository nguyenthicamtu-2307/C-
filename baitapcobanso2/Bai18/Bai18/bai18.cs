using System;

namespace Bai18
{
    class bai18
    {
        static void Main(string[] args)
        {
            long h253, t253, n253;
            Console.Write("Nhap so gio: ");
            h253 = long.Parse(Console.ReadLine());

            t253 = h253 / (24 * 7);
            n253 = (h253 % (24 * 7)) / 24;
            h253 = (h253 % (24 * 7)) % 24;

            Console.WriteLine($"{t253} tuan, {n253} ngay, {h253} gio");
            Console.ReadKey();
        }
    }
}
