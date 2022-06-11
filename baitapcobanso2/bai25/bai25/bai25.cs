using System;

namespace bai25
{
    class bai25
    {
        static void Main(string[] args)
        {
            int a253, b253, c253, d253 ,n253;
            Console.Write("nhập 2 số a,b:");
            a253 = Convert.ToInt32(Console.ReadLine());
            b253= Convert.ToInt32(Console.ReadLine());
            c253 = a253 * b253;
            while (b253 != 0)
            {
                d253 = a253 % b253;
                a253 = b253;
                b253 = d253;
            }
            Console.Write("uoc chung lon nhat la :" + a253);
            Console.Write("\n boi chung nho nhat la :" + c253/a253);
        }
    }
}
