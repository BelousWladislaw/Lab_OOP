using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belous_labs
{
    internal class B : A
    {
        public int d;

        public B() { }

        public B(int a, int b, int d) : base(a, b) { 
        
            this.d = d;
        }

        public float C3
        {
            get
            {
                for (int i = 0; i < d; i++)
                {
                    a *= b;
                }
                return a;
            }
        }
    }
}


