using Assignment.DAL;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.BLL
{
    public class CustomerOrder : ICustomerOrder
    {
        public string AddCustomerOrder(CustomerOrderViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    Order orderObj = new Order();
                    orderObj.CustomerId = obj.CustomerId;
                    orderObj.OrderType = obj.OrderType;
                    orderObj.PaymentType = obj.PaymentType;
                    orderObj.GrandTotal = obj.GrandTotal;
                    orderObj.deliveryDate = obj.deliveryDate;
                    orderObj.isStatus = true;
                    orderObj.createdDate = orderObj.updatedDate = DateTime.Now;
                    orderObj.noofItems = obj.noofItems;
                    db.Orders.Add(orderObj);
                    db.SaveChanges();
                    return "Ok";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CustomerOrderViewModel> GetCustomerOrderList()
        {
            throw new NotImplementedException();
        }
    }
}