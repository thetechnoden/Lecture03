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
            double trianglePerimeter = triangle.CalculatePerimeter();

            Point D = new Point(9, 6, "D");
            Point E = new Point(1, 6, "E");

            Figure pentagon = new Figure(A, B, C, D, E);
            double pentagonPerimeter = pentagon.CalculatePerimeter();

            Console.WriteLine($"Name of polygon: {triangle.GetPoints().Count}-angle");
            Console.WriteLine($"Perimeter: {trianglePerimeter}");

            Console.WriteLine($"Name of polygon: {pentagon.GetPoints().Count}-angle");
            Console.WriteLine($"Perimeter: {pentagonPerimeter}");
        }
    }
  






}
