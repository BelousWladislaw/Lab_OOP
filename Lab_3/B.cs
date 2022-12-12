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

        public int[] arr;
        public B(int d)
        {
            a = 7;
            b = 1;
            this.d = d;
        }
        public B() : this(3)
        {
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = C2 * i;

        }
        public B(int a, int b, int d) : base(a, b)
        {

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


