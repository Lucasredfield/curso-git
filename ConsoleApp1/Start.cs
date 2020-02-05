using CourseApp.Business;
using CourseApp.Models;
using CourseApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CourseApp
{
    class Start
    {
        static void Main(string[] args)
        {
            //TriangleBusiness triangleBusiness = new TriangleBusiness();
            //ProductBusiness productBusiness = new ProductBusiness();
            //CurrencyConverterBusiness currencyConverterBusiness = new CurrencyConverterBusiness();
            //BankAccountBusiness bankAccountBusiness = new BankAccountBusiness();
            //EmployeeBusiness employeeBusiness = new EmployeeBusiness();

            //currencyConverterBusiness.Start();
            //productBusiness.Start();
            //triangleBusiness.Start();
            //employeeBusiness.Start();

            Order order = new Order()
            {
                Id = 1,
                Date = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);


            Console.Read();

        }
    }
}
