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

        public int[] arr1;
        private float[] arr2 = new float[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        public int this[int ind1]
        {
            get { return arr1[ind1]; }
            set { arr1[ind1] = value; }
        }
        public float this[float ind2] { 
            get { return arr2[(int)ind2]; }
            set { arr2[(int)ind2] = value; }
        }

        public B(int d)
        {
            a = 7;
            b = 1;
            this.d = d;
        }
        public B() : this(3)
        {
            arr1 = new int[a];
            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = C2 * i;

        }
        public B(int a, int b, int d) : base(a, b)
        {

            this.d = d;
        }    
        public static Boolean operator true(B b)
        {
            return b.d != 0;
        }

        public static Boolean operator false(B b)
        {
            return b.d == 0;
        }

        public static Boolean operator !(B b)
        {
            return !(b.d == 1);
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


