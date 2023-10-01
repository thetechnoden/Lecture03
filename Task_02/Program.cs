using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 4, "B");
            Point C = new Point(3, 0, "C");

            Figure triangle = new Figure(A, B, C);
            triangle.CalculatePerimeter();

            Point D = new Point(4, 0, "D");
            Point E = new Point(0, 3, "E");

            Figure pentagon = new Figure(A, B, C, D, E);
            pentagon.CalculatePerimeter();
        }
    }
}
