using System;

namespace bai12
{
    class bai12
    {
        static void Main(string[] args)
        {
            float a253, b253, c253, x253, y253, z253, d253, t253, m253;
            Console.Write("nhập a1,b1,c1:");
            a253 = Convert.ToInt32(Console.ReadLine());
            b253 = Convert.ToInt32(Console.ReadLine());
            c253 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhập a2,b2,c2: ");
            x253 = Convert.ToInt32(Console.ReadLine());
            y253 = Convert.ToInt32(Console.ReadLine());
            z253 = Convert.ToInt32(Console.ReadLine());
            m253 = (a253 * y253 - b253 * x253);
            d253 = (c253 * y253 - z253 * b253);
            t253 = (a253 * z253 - x253 * c253);
            if(m253)
        }
    }
}
