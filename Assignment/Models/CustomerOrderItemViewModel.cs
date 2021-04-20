using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class CustomerOrderItemViewModel
    {

        public int ItemID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> productId { get; set; }
        public Nullable<double> itemPrice { get; set; }
        public Nullable<int> ItemQuantity { get; set; }
        public Nullable<double> DiscountAmount { get; set; }
        public Nullable<double> GrandTotal { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isStatus { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public string createdUserBy { get; set; }
        public string updatedUserBy { get; set; }

    }
}