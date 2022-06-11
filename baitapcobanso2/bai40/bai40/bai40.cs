using System;

namespace bai40
{
    class bai40
    {
        static void Main(string[] args)
        {
            int x253, y253, z253;
            for (x253 = 1; x253 < 100 / 5; x253++)
            {
                for (y253 = 1; y253 < 100 / 3; y253++)
                {
                    z253 = 100 - (x253 + y253);
                    if (300 == 15 * x253 + 9 * y253 + z253)
                    {
                        Console.Write("\n so trâu dung :" + x253 );
                        Console.Write(" \n so trâu nam :" + y253);
                        Console.Write(" \n so trâu gia :" + z253);
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
