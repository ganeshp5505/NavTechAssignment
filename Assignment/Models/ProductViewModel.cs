using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class ProductViewModel
    {
        public int productId { get; set; }

        [Required]
        public string productName { get; set; }

        [Required]
        public string code { get; set; }

        [Required]
        public string productDescription { get; set; }
        public Nullable<int> stocksLeft { get; set; }
        [Required]
        [Range(0, 999)]
        public Nullable<int> stockQuantity { get; set; }
        public Nullable<double> actualPrice { get; set; }
        public Nullable<double> offeredPrice { get; set; }
        public Nullable<bool> isStatus { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public string createdUserBy { get; set; }
        public string updatedUserBy { get; set; }
    }
}