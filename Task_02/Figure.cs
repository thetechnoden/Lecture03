using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Figure
    {
        private List<Point> points = new List<Point>();

        public Figure(params Point[] points)
        {
            this.points.AddRange(points);
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

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i + 1) % points.Count;
                perimeter += GetSideLength(points[i], points[nextIndex]);
            }
            return perimeter;
        }

        public List<Point> GetPoints()
        {
            return points;
        }
    }
}
