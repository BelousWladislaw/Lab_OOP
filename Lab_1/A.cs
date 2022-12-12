using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belous_labs
{
    internal class A
    {
        private int a;

        private int b;

        public A() { }

        public A(int a, int b) {
            this.a = a;
            this.b = b;
        }

        public float C1()
        {
            return a * b;
        }

        public float C2()
        {
            return a - b;
        }
    }
}
