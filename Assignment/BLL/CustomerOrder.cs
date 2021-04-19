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
                    //Product cus = db.Products.Where(m => m.productId == obj.id).FirstOrDefault();
                    //cus.isStatus = false;
                    //db.SaveChanges();
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