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
            B b = new B();
            
            for (float i = 0; i < 10; i++)
            {
                Console.WriteLine(b[i]);
            }

            C<int> c1 = new C<int>();
            C<string> c2 = new C<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(c1[i]);
                Console.WriteLine(c2[i]);
            }
          Console.Read();

        }
    }
}