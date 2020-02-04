using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    class Customer
    {
        public string _name;
        public string Email { get; set; }
        public string ReserveProduct { get; set; }
        public  DateTime ReserveDate { get; set; }

        public Customer()
        {
        }

        public Customer(string name, string email)
        {
            this._name = name;
            this.Email = email;
        }

        public Customer(string name, string email, string reserveProduct):this(name,  email)
        {
            this.ReserveProduct = reserveProduct;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != "")
                {
                    _name = value;
                }
            }
        }

        public override string ToString()
        {
            return
                  " Nome: " + Name
                + "\n Email: " + Email
                + "\n Produto: " + ReserveProduct;
        }

    }
}
