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


            //DateTime d = DateTime.Now;
            //string dataConvert = d.ToString("dd/MM/yyyy");
            //Console.WriteLine(dataConvert);
            /*
            string d = Console.ReadLine().ToString();            
            DateTime date = DateTime.Parse(d);            
            //DateTime date = DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture);            
            Console.WriteLine(date);           
            Console.WriteLine(d);
            /*
           TimeSpan t1 = new TimeSpan();
           TimeSpan t2 = new TimeSpan(900000000L);
           TimeSpan t3 = new TimeSpan(2, 11, 21);
           TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
           TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
           Console.WriteLine(t1);
           Console.WriteLine(t2);
           Console.WriteLine(t3);
           Console.WriteLine(t4);
           Console.WriteLine(t5);

           DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
           DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
           DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
           Console.WriteLine("d1: " + d1);
           Console.WriteLine("d1 Kind: " + d1.Kind);
           Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
           Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
           Console.WriteLine();
           Console.WriteLine("d2: " + d2);
           Console.WriteLine("d2 Kind: " + d2.Kind);
           Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
           Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
           Console.WriteLine();
           Console.WriteLine("d3: " + d3);
           Console.WriteLine("d3 Kind: " + d3.Kind);
           Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
           Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
           //DateTime d1 = DateTime.Now;
           //Console.WriteLine(d1);
           //Console.WriteLine(d1.Ticks);
           //DateTime d1 = new DateTime(2000, 8, 15);
           //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
           //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
           //Console.WriteLine(d1);
           //Console.WriteLine(d2);
           //Console.WriteLine(d3);
           //DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
           //DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
           //Console.WriteLine(d1);
           //Console.WriteLine(d2);
           //Console.Read();

            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);           
            */
            Console.Read();

        }
    }
}
