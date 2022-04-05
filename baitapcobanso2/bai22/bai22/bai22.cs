using System;

namespace bai22
{
    class bai22
    {
        static void Main(string[] args)
        {
            int a253, i253,count253,sum253;
            Console.Write("Nhập so:");
            a253 = Convert.ToInt32(Console.ReadLine());
            Console.Write("cac uoc cua so la:");
            for (count253 = sum253 = 0, i253 = 1; i253 <= a253; i253++){
                if(a253% i253 == 0)
                {
                    Console.Write("" + i253);
                    count253++;
                    sum253 += i253;
                }
            }
            Console.Write("\n co " + count253 + "ươc so và tong la " + sum253);
            Console.ReadKey();
        }
    }
}
