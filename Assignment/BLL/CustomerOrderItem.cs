using Assignment.DAL;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.BLL
{
    public class CustomerOrderItem : ICustomerOrderItem
    {
        public string AddCustomerOrderItems(CustomerOrderItemViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    OrderItem orderObj = new OrderItem();
                    orderObj.OrderID = obj.OrderID;
                    orderObj.productId = obj.productId;
                    orderObj.itemPrice = obj.itemPrice;
                    orderObj.GrandTotal = obj.GrandTotal;
                    orderObj.DiscountAmount = obj.DiscountAmount;
                    orderObj.isStatus = true;
                    orderObj.createdDate = orderObj.updatedDate = DateTime.Now;
                    db.OrderItems.Add(orderObj);
                    db.SaveChanges();
                    return "Ok";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CustomerOrderItemViewModel> GetCustomerOrderList()
        {
            throw new NotImplementedException();
        }
    }
}