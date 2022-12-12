using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belous_labs
{
    internal class A
    {
        public int a;

        public int b;

        public A() { }

        public A(int a, int b) {
            this.a = a;
            this.b = b;
        }

        public float C1
        {
            get
            {
                return a * b;
            }

        }
        public float C2 {
            get { 
        
                return a - b;
            }   
        }
    }
}
        
