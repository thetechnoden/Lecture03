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
            Point A = new Point(4, 1, "A");
            Point B = new Point(44, 9, "B");
            Point C = new Point(6, 5, "C");

            Figure triangle = new Figure(A, B, C);
            triangle.CalculatePerimeter();

            Point D = new Point(9, 6, "D");
            Point E = new Point(1, 6, "E");

            Figure pentagon = new Figure(A, B, C, D, E);
            pentagon.CalculatePerimeter();
        }
    }
}
