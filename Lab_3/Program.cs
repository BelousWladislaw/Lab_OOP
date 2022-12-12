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
            foreach (int el in b.arr)
            {
                Console.WriteLine(el);
            }
                     
        }
    }
}