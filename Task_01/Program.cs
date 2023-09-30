using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2;

            Console.WriteLine("Enter the length of the first side of the rectangle:");
            if (double.TryParse(Console.ReadLine(), out side1))
            {
                Console.WriteLine("Enter the length of the second side of the rectangle:");
                if (double.TryParse(Console.ReadLine(), out side2))
                {
                    Rectangle rectangle = new Rectangle(side1, side2);

                    Console.WriteLine($"Perimeter of the rectangle: {rectangle.Perimeter}");
                    Console.WriteLine($"Area of the rectangle: {rectangle.Area}");
                }
                else
                {
                    Console.WriteLine("Incorrect value for the length of the second side.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect value for the length of the first side.");
            }

            Console.ReadLine();
        }
    }
}

