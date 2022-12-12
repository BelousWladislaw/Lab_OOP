using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Comparer : IComparer<Human>
    {
        public int Compare(Human obj1, Human obj2)
        {
            String first = obj1.LastName;
            String second = obj2.LastName;

            return String.Compare(first, second);
        }
    }
}
