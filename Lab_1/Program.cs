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
            A a = new A(3, 5);
            Console.WriteLine(a.C1());
            Console.WriteLine(a.C2());

        }
    }
}