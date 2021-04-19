using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class CustomerOrderViewModel
    {
        public int orderId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string OrderType { get; set; }
        public Nullable<double> TotalAmount { get; set; }
        public Nullable<double> DiscountAmount { get; set; }
        public Nullable<double> GrandTotal { get; set; }
        public string PaymentType { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<System.DateTime> deliveryDate { get; set; }
        public Nullable<int> noofItems { get; set; }
        public string deliveryType { get; set; }
        public Nullable<bool> isStatus { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
    }
}