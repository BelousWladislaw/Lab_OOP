using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    class Program
    {
		public static void Main()
		{
			square f1 = new square(5);
			square f2 = new square(8);
			circle f3 = new circle(3, "red");
			circle f4 = new circle(7, "green");
			IFigure[] figures = new string[] {f1, f2, f3, f4};

			Container arr = new Container(figures);
			foreach (string a in arr)
			{
				Console.WriteLine(a);
			}
		}
	}
}
