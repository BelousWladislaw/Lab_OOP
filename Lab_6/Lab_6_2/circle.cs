using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    class circle : IFigure
    {
        private int radius;
        private String colour;

        public circle(int newRadius, String newColour)
        {
            radius = newRadius;
            colour = newColour;
        }

        public double space
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public void info()
        {
            Console.WriteLine($"radius of circle = {radius}");
            Console.WriteLine($"colour of circle = {colour}");
            Console.WriteLine($"circle space size = {space}");
        }
    }
}