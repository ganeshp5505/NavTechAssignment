using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BLL
{
    interface ICustomerOrderItem
    {
        string AddCustomerOrderItems(CustomerOrderItemViewModel obj);
        List<CustomerOrderItemViewModel> GetCustomerOrderList();
    }
}
