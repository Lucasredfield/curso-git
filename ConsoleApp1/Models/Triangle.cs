using System;

namespace CourseApp
{
    class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle()
        {
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area(double sideA, double sideB, double sideC)
        {            
            double semiPerimeter = Perimeter(sideA, sideB, sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        public double Perimeter(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB + sideC);
        }

    }
}
