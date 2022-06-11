using System;

namespace bai3
{
    class bai3

    {
        static void Main(string[] args)
        {
            float a253, b253, c253;
            Console.Write("Nhap canh a: ");
            a253 = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            b253 = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            c253 = float.Parse(Console.ReadLine());

            /* Kiem tra xem tong ba goc co bang 180 do */
            if (a253 <= 0 || b253 <= 0 || c253 <= 0)
                Console.Write("Day khong phai 3 canh cua tam giac\n");
            else
                Console.Write("Day la 3 canh cua tam giac\n");
            Console.ReadKey();

        }
    }
}
