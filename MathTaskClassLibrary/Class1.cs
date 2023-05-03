using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea(int a,int b)
        {
               return a * b + 10;
        }
        public double Cilinder(double r, double h)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2) * h, 2) + 1;
        }
        public double Disckiriminant(int a, int b, int c)
        {
            return (b * b) - (4 * a * c -1);
        }
    }
}
