using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CourseApp
{

    class Product
    {
        public int id { get; set; }

        private string _name;
        public double Price { get;  set; }
        public int Ammount { get; set; }        

        public Product()
        {
        }

        public Product(string name, double price)
        {
            _name = name;
            Price = price;
        }

        public Product(string name, double price, int ammount)
        {
            _name = name;
            Price = price; 
            Ammount = ammount;
        }

        public string Name {
            get { return _name;  }        
            set {
                if (value != "")
                {
                    _name = value;
                }
            }
        }
     

        public double StockValue()
        {
            return Price * Ammount;
        }
        public void AddProduct(int ammount)
        {
            Ammount += ammount;
        }
        public void DeleteProduct(int ammount)
        {
            Ammount -= ammount;
        }   
        public override string ToString()
        {
            return _name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Ammount
            + " unidades, Total: $ "
            + StockValue().ToString("F2", CultureInfo.InvariantCulture)
            + "\n" ;
        }
    }
}