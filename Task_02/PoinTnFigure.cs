using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Point
    {
        private double x;
        private double y;
        private string name;

        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }
    }

    class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        private double GetDistance(Point A, Point B)
        {
            double deltaX = B.X - A.X;
            double deltaY = B.Y - A.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public double GetSideLength(Point A, Point B)
        {
            return GetDistance(A, B);
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length;
                perimeter += GetSideLength(points[i], points[nextIndex]);
            }

            Console.WriteLine($"Name of polygon: {points.Length}-angle");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}
