using Belous_labs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belous_labs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            A a1 = new A(3, 5);
            A a2 = new A();
            B b1 = new B(6, 2, 4);
            B b2 = new B();
            Console.WriteLine(a1.C1);
            Console.WriteLine(a1.C2);
            Console.WriteLine(a2.C1);
            Console.WriteLine(a2.C2);
            Console.WriteLine(b1.C3);
            Console.WriteLine(b2.C3);

        }
    }
}