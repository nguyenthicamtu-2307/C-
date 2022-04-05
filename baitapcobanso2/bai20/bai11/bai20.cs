using System;

namespace bai18

{
    class bai20
    {
        static void Main(string[] args)
        {
            int a253,b253;
            Console.Write("Nhap so kw tieu thu: ");
            a253 = Convert.ToInt32(Console.ReadLine());
            if (a253 < 100)
            {
                b253 = a253 * 500;
                Console.Write("so tien la:"+b253);
            }
               
            else
                if (100 < a253 && a253 < 250)
            {
                b253 = a253 * 800;
                Console.Write("so tien la:"+ b253);
            }
               
            else
                    if (a253 < 250 && a253 < 350)
            {
                b253 = a253 * 1000;
                Console.Write("so tien la:"+ b253);
            }
                
            else
            {
                b253 = a253 * 1500;
                Console.Write("so tien la:"+b253);
            }
                
            Console.ReadKey();
        }
    }
}
