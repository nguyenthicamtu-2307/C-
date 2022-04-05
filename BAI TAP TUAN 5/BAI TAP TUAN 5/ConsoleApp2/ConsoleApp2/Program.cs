using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bai2();

            Console.ReadLine();
        }

        public static void bai1()
        {
            Console.Write("Nhap so tu nhien n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Tong cua " + n + " so tu nhien dau tien la: " + sum);
        }

        public static void bai2()
        {
            //a(1+r)^n
            Console.Write("Nhap so tien gui ban dau: ");
            double tienGoc = double.Parse(Console.ReadLine());
            Console.Write("Nhap lai suat hang nam: ");
            double laiSuat = double.Parse(Console.ReadLine());
            Console.Write("Nhap so nam gui: ");
            double soNam = double.Parse(Console.ReadLine());

            double tienLai = tienGoc * Math.Pow((1 + (laiSuat / 100)), soNam);
            Console.WriteLine("So tien nhan duoc sau "+soNam+" nam la "+tienLai); 
        }

        
    }
}
