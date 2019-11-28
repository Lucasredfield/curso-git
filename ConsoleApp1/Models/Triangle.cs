using System;

namespace CourseApp
{
    class Triangle
    {
        public double SideA;
        public double SideB;
        public double SideC;

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
