using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVERLOADING
{
    class Program
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void add(string s1, string s2)
        {
            Console.WriteLine(s1 + s2);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.add(10, 20);
            obj.add(10.5f, 20.5f);
            obj.add("ASHIQ", "AMEER");
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}