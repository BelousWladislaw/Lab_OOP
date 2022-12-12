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
            B b1 = new B(1, 3, 0);
            if (b1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            B b2 = new B(1, 3, 2);
            
            if (b2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            B b3 = new B(1, 3, 1);
            Console.WriteLine(!b3);
           

        }
    }
}