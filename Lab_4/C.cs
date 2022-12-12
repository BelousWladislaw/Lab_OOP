using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belous_labs
{
    public class C<T>
    {
        public static int a = 5;

        private T[] imyArray = new T[5];
        public T this[int ind1]
        {
            get { return imyArray[ind1]; }
            set { imyArray[ind1] = value; }
        }
    }

}


