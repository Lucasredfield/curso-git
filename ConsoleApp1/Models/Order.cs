using CourseApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp.Models
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Date
                + ", "
                + Status;
        }
    }
}
