using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CourseApp.Business
{
    class ProductBusiness
    {
        public void Start()
        {
            Console.Write("Entre com a quantidade de produto: ");
            int ammountProduct = int.Parse(Console.ReadLine());

            Product[] products = new Product[ammountProduct];

            for (int i = 0; i < ammountProduct; i++)
            {
                Console.WriteLine("---Produto: " + i + " ---");
                Console.Write("Nome: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Unidades: ");
                int ammount = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products[i] = new Product { Name = nameProduct, Price = price, Ammount = ammount };
            }

            double sum = 0;
            for (int i = 0; i < ammountProduct; i++)
            {
                sum += products[i].Price;
            }
            double average = sum / ammountProduct;

            for (int i = 0; i < ammountProduct; i++)
            {
                Console.WriteLine();
                Console.WriteLine("---Dados do produto: " + i + " ---");
                Console.Write(products[i].ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Média dos preços: " + average.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("---RESERVAS DE PRODUTOS---");

            Console.WriteLine();
            Console.WriteLine("Insira a quantidade de clientes que reservaram produtos: ");
            int ammountCustomer = int.Parse(Console.ReadLine());
            Customer[] customers = new Customer[ammountCustomer];
            Console.WriteLine();
            Console.WriteLine("Insira os dados dos clientes");

            for (int i = 0; i < ammountCustomer; i++)
            {
                Console.WriteLine("\n---Dados do cliente: " + i + " ---");
                Console.Write("Nome: ");
                string nameCustomer = Console.ReadLine().ToString();
                Console.Write("Email: ");
                string emailCustomer = Console.ReadLine().ToString();
                customers[i] = new Customer { Name = nameCustomer, Email = emailCustomer };

                Console.Write("Qual produto foi reservado: ");
                string reserveProduct = Console.ReadLine().ToString();

                Console.WriteLine("Qual data de reserve? (dd/mm/yyyy)");
                DateTime dateReserve = DateTime.Parse(Console.ReadLine());

                foreach (var item in products)
                {
                    if (item.Name.Equals(reserveProduct))
                    {
                        customers[i] = new Customer { Name = nameCustomer, Email = emailCustomer, ReserveProduct = reserveProduct };
                        break;
                    }
                }
            }

            for (int i = 0; i < ammountCustomer; i++)
            {
                if (customers[i].ReserveProduct != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("---Reservas--- \n Rent# " + i);
                    Console.Write(customers[i].ToString());
                }
            }

            Console.ReadLine();
        }
    }
}

