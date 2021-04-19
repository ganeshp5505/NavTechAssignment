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
    public class CustomerOrderController : ApiController
    {
        public HttpResponseMessage AddCustomerOrder(CustomerOrderViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    CustomerOrder model = new CustomerOrder();
                    model.AddCustomerOrder(obj);
                }

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }

            return Request.CreateResponse(HttpStatusCode.OK, "Successfull");
        }
    }
}
