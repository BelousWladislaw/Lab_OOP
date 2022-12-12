using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    class square : IFigure
    {
        private int side;

        public double space
        {
            get
            {
                return side * Math.Sqrt(2);
            }
        }
        public void info()
        {
            Console.WriteLine($"square side size = {side}");
            Console.WriteLine($"square spase size = {space}");
            Console.WriteLine($"square perimeter size = {perimeter()}");
        }
        public square(int newSide)
        {
            side = newSide;
        }

        public int perimeter()
        {
            return 4 * side;
        }
    }
}
