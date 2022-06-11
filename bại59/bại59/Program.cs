using System;

namespace bai59

{
    class Program
    {
        static void Main(string[] args)
        {
            int n253;
           String [] can253 =new String[] {"Canh", "Tan", "Nham", "Quy", "Giap",
         "At", "Binh", "Dinh", "Mau", "Ky"};

            String[] chi253 = new String[] {"Than", "Dau", "Tuat", "Hoi", "Ti", "Suu",
             "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui"};
            Console.Write("nhap vao nam: ");
            n253 = Convert.ToInt32(Console.ReadLine());
           Console.Write($"  {n253},{can253[n253 % 10]} {chi253[n253 % 12]}");
            Console.Write($"\n {n253 + 60},{can253[n253 % 10]} {chi253[n253 % 12]}");
            Console.ReadKey();

        }
       
    }
}