using Assignment.BLL;
using Assignment.DAL;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment.Controllers
{
    public class CustomerOrderItemsController : ApiController
    {
        public HttpResponseMessage AddCustomerOrder(CustomerOrderItemViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    CustomerOrderItem model = new CustomerOrderItem();
                    model.AddCustomerOrderItems(obj);
                }

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }

            return Request.CreateResponse(HttpStatusCode.OK, "Successfull");
        }

        public HttpResponseMessage GetCustomerOrderList()
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.GetCustomerOrderItemList().ToList();

                    return Request.CreateResponse(HttpStatusCode.OK, checkingData);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }
        }
    }
}
