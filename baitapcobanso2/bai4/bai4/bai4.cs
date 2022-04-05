using System;

namespace bai4
{
    class bai4
    {
        static void Main(string[] args)
        {

            int a253, b253, c253;
            Console.Write("Nhap canh a: ");
            a253 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            b253 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            c253 = Convert.ToInt32(Console.ReadLine());

            /* Kiem tra xem tong ba goc co bang 180 do */
            if (a253 <= 0 || b253 <= 0 || c253 <= 0)
                Console.Write("khong phai 3 canh cua tam giac\n");
            else
            {
                    {
                        if (a253 * a253 + b253 * b253 == c253 * c253 || a253 * c253 + c253 * c253 == b253 * b253 || b253 * b253 + c253 * c253 == a253 * c253)
                        {
                            Console.Write("Day la tam giac vuong.\n");
                        }
                        else
                            Console.Write("Day la tam giac thuong.\n");
                    }
                }
            
            Console.ReadKey();
        }
    }
}

