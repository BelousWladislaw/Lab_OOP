using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    class Container : IEnumerable
    {
        IFigure[] figures;

        public Container(IFigure[] gf)
        {
            figures = gf;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return figures.GetEnumerator();
        }
    }
}
