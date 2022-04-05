using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class person
        {
            int age;
            string name;

            public person(int age, string ht)
            {
                this.age = age;
                this.name = ht;
            }

            public string doTuoi()
            {
                if (this.age >= 60)
                    return "Nguoi gia";
                else if (this.age >= 18)
                    return "Nguoi lon";
                else
                    return "Em be";
            }

            public int Age { get => age; set => age = value; }
            public string Name { get => name; set => name = value; }
        }
        static void Main(string[] args)
        {
            nhapTuoi();

            Console.ReadLine();
        }

        static void nhapTuoi()
        {
            string ht;
            int age;

            Console.WriteLine("Nhap nguoi thu nhat: ");
            Console.Write("Ho ten: ");
            ht = Console.ReadLine();
            Console.Write("Tuoi: ");
            age = int.Parse(Console.ReadLine());
            person ps1 = new person(age, ht);

            Console.WriteLine("Nhap nguoi thu hai: ");
            Console.Write("Ho ten: ");
            ht = Console.ReadLine();
            Console.Write("Tuoi: ");
            age = int.Parse(Console.ReadLine());
            person ps2 = new person(age, ht);

            Console.WriteLine("Nhap nguoi thu ba: ");
            Console.Write("Ho ten: ");
            ht = Console.ReadLine();
            Console.Write("Tuoi: ");
            age = int.Parse(Console.ReadLine());
            person ps3 = new person(age, ht);

            Console.WriteLine(ps1.Name + " la " + ps1.doTuoi());
            Console.WriteLine(ps2.Name + " la " + ps2.doTuoi());
            Console.WriteLine(ps3.Name + " la " + ps3.doTuoi());
        }
    }
}
