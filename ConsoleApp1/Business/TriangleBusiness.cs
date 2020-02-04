using System;
using System.Globalization;

namespace CourseApp
{
    class TriangleBusiness
    {
        public void Start()
        {
            Console.WriteLine("Quantos triangulos deseja calcular? Lim. 3");

            int ammount = int.Parse(Console.ReadLine());

            if (ammount > 3)
            {
                Console.WriteLine("O limite é 3, seu valor de " + ammount + " foi redefinido para 3. \n");
                ammount = 3;
            }
            if (ammount <= 0)
            {
                Console.WriteLine("Nenhum triangulo calculado");
                Console.Read();
                return;
            }

            double[] area = new double[ammount];

            for (int i = 0; i < ammount; i++)
            {
                area[i] = CalculateTriangle(i);
                Console.WriteLine("\n---- Concluido: " + i + "------\n");
            }

            CheckTriangleArea(ammount, area);
        }

        static double CalculateTriangle(int i)
        {
            Console.WriteLine("Entre com as medidas do " + i + "° triângulo: ");
            Triangle triangle = new Triangle(
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine())
            );

            double area = triangle.Area(triangle.SideA, triangle.SideB, triangle.SideC);

            Console.WriteLine("Área do " + i + " triângulo: " + area.ToString("F4", CultureInfo.InvariantCulture));

            return area;
        }

        static void CheckTriangleArea(int ammount, double[] area)
        {
            double biggerArea = 0;
            double smallerArea = 0;
            int biggerTriangle = 0;
            int smallerTriangle = 0;

            for (int i = 0; i < ammount; i++)
            {
                if (i == 0)
                {
                    biggerArea = area[0];
                    smallerArea = area[0];
                }

                if (area[i] > biggerArea)
                {
                    biggerArea = area[i];
                    biggerTriangle = i;
                }

                if (area[i] < smallerArea)
                {
                    smallerArea = area[i];
                    smallerTriangle = i;

                }
            }
            Console.WriteLine("\nA menor area é: " + smallerArea + ", do Triangulo: " + smallerTriangle + "°");
            Console.WriteLine("\nA maior area é: " + biggerArea + ", do Triangulo: " + biggerTriangle + "°");
            Console.Read();
        }
    }
}