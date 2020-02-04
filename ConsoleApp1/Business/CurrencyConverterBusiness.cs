using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using CourseApp.Models;

namespace CourseApp.Business
{
    class CurrencyConverterBusiness
    {
        public void Start()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = CurrencyConverter.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
