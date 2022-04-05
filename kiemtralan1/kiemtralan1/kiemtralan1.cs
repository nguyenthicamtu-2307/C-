using System;

namespace kiemtralan1
{
    class kiemtralan1
    {
        
        static void Main(string[] args)
        {
            int chon253;
            do
            {
                Console.WriteLine("*******Bai Tap So 1 ***********");
                Console.WriteLine("1. Viết phương thức in ra tổng, hiệu, tích, thương của 2 số đc nhập vào bàn phím cho trước.");
                Console.WriteLine("2. Viết phương thức In ra lá cờ Việt Nam bằng các dấu = và *");
                Console.WriteLine("3. Viết phương thức đổi số thập phân thành số nhị phân từ một số thập phân nhập vào từ bàn phím.");
                Console.WriteLine("4. Viết phương thức in ra các thông tin của bản thân (họ tên, lớp, mã sv)");
                Console.WriteLine("Moi chon bai: ");

                Console.WriteLine("**-----------------------------------------**");





                 chon253 = int.Parse(Console.ReadLine());
                switch (chon253)
                {
                    case 1:
                        tonghieu();
                        break;
                    case 2:
                        break;
                    case 3:
                        dectobin();
                        break;
                    case 4:
                        info();
                        break;

                    default:
                        break;
                }
            }
            while (chon253 <=4);
            Console.ReadKey();

        }
        static int tonghieu()
        {
            int a253, b253;
            int tong253, hieu253, tich253, thuong253;
            Console.Write("Nhap so a: ");
            a253 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap so b: ");
            b253 = Convert.ToInt32(Console.ReadLine());

            tong253 = a253 + b253;
            hieu253 = a253 - b253;
            tich253 = a253 * b253;
            thuong253 = a253 / b253;
            Console.Write($"\n Tong cua 2 so là : {tong253}");
            Console.Write($"\n Hieu cua 2 so la : {hieu253}");
            Console.Write($"\n Thuong cua 2 so la : {thuong253}");
            Console.Write($"\n Tich cua 2 so la : {tich253}");
            return 0;
        }
       static long dectobin()
        {
            Console.Write("\n Nhap so can chuyen doi: ");
            int number253 = int.Parse(Console.ReadLine());
            int i253;
            string Result253 = string.Empty;
            for (i253 = 0; number253 > 0; i253++)
            {
                Result253 = number253 % 2 + Result253;
                number253 = number253 / 2;


            }
            Console.WriteLine($"\n so thap phan sau chuyen doi: {Result253}");

            return 0;
        }
        static void info()
        {
            Console.Write("Ho va ten :Nguyen Thi Cam Tu");
            Console.Write("\n Ma sinh vien: 1911505310253");
            Console.Write("\n Lop sinh hoat: 19T2");
            Console.Write("\n Que quan: Ha Tinh");
            Console.Write("\n Ngay sinh: 23/07/2001");
        }
    }
}
