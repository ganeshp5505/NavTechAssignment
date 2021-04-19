using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class RegisterViewModel
    {
        public int customerId { get; set; }

        [Required]
        public string customername { get; set; }
        [Required]
        public string mobileNumber { get; set; }
        [Required]
        public string emailId { get; set; }
        public Nullable<bool> gender { get; set; }
        [Required]
        public string customerAddress { get; set; }
        public Nullable<bool> isStatus { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public string createdUserBy { get; set; }
        public string updatedUserBy { get; set; }
    }
}