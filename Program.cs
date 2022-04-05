using System;

namespace baistruct
{
    class Program
{
        public struct sinhvien
        {
            public string maso253;
            public string hoten253;
            public double diemtoan253;
            public gioitinh gioitinh253;
            public double diemly253;
            public double diemhoa253;
        }
        public enum gioitinh
        {
            Nam,
            Nu
        };
        public enum hocluc
        {
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        };
        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                Console.Write("Ho ten: ");
                string ht253 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv253 = Console.ReadLine();
                Console.Write("Gioi tinh (0: nam  1: nu): ");
                int gt253 = int.Parse(Console.ReadLine());
                Console.Write("Diem toan: ");
                double dt253 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl253 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh253 = double.Parse(Console.ReadLine());


                sv[i].hoten253 = ht253;
                sv[i].maso253 = msv253;
                if (gt253 == 0)
                    sv[i].gioitinh253 = gioitinh.Nam;
                else
                    sv[i].gioitinh253 = gioitinh.Nu;
                sv[i].diemtoan253 = dt253;
                sv[i].diemly253 = dl253;
                sv[i].diemhoa253 = dh253;

            }
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i = 1;
            foreach (sinhvien item253 in sv)
            {
                Console.WriteLine("----- " + i + " -----");
                Console.WriteLine("Ho ten: " + item253.hoten253);
                Console.WriteLine("Ma sinh vien: " + item253.maso253);
                int gt = (int)item253.gioitinh253;
                if (gt == 0)
                    Console.WriteLine("Gioi tinh: Nam");
                else
                    Console.WriteLine("Gioi tinh: Nữ");
                Console.WriteLine("Diem toan: " + item253.diemtoan253);
                Console.WriteLine("Diem ly: " + item253.diemly253);
                Console.WriteLine("Diem hoa: " + item253.diemhoa253);
                int hocluc = (int)diemTB(item253.diemtoan253, item253.diemly253, item253.diemhoa253);
                switch (hocluc)
                {
                    case 0:
                        Console.WriteLine("Hoc luc: Yeu");
                        break;
                    case 1:
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;
                    case 2:
                        Console.WriteLine("Hoc luc: Kha");
                        break;
                    case 3:
                        Console.WriteLine("Hoc luc:Gioi");
                        break;

                }

                i++;
            }
        }
        public static hocluc diemTB(double toan, double ly, double hoa)
        {
            double dtb = (toan + ly + hoa) / 3;
            if (dtb <= 4)
                return hocluc.Yeu;
            else if (dtb <= 5)
                return hocluc.TrungBinh;
            else if (dtb <= 7)
                return hocluc.Kha;
            else
                return hocluc.Gioi;
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach (sinhvien item117 in sv)
            {
                if (item117.hoten253 == ht)
                {
                    Console.WriteLine("Ho ten: " + item117.hoten253);
                    Console.WriteLine("Ma sinh vien: " + item117.maso253);
                    int gt = (int)item117.gioitinh253;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                        Console.WriteLine("Gioi tinh: Nữ");
                    Console.WriteLine("Diem toan: " + item117.diemtoan253);
                    Console.WriteLine("Diem ly: " + item117.diemly253);
                    Console.WriteLine("Diem hoa: " + item117.diemhoa253);
                    int hocluc = (int)diemTB(item117.diemtoan253, item117.diemly253, item117.diemhoa253);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n253 = int.Parse(Console.ReadLine());
            sinhvien[] sv253 = new sinhvien[n253];
            nhapDS(ref sv253, n253);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv253, n253);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht253 = Console.ReadLine();
            timKiem(sv253, n253, ht253);

            Console.ReadLine();
        }
}
}
