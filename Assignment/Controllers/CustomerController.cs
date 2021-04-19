
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
    public class CustomerController : ApiController
    {
      
        
        public HttpResponseMessage AddCustomer(RegisterViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.Customers.Any(m => m.emailId == obj.emailId || m.mobileNumber == obj.mobileNumber);

                    if (checkingData)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Customer already exists. Please try new");
                    }
                    else
                    {
                        Register model = new Register();
                        model.AddUser(obj);
                    }
                    
                }
                
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest,"Somthing went wrong");
            }
           
            return Request.CreateResponse(HttpStatusCode.OK, "Registered Successfully");
        }


        public HttpResponseMessage DeleteCustomer(int id)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.Customers.Any(m => m.customerId == id);
                    if (!checkingData)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Customer Not Found");
                    }
                    else
                    {
                        Register model = new Register();
                        model.DeleteUser(id);
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted Successfully");
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }
        }

        public HttpResponseMessage EditCustomer(RegisterViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.Customers.Any(m => m.customerId == obj.customerId);
                    if (!checkingData)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Customer Not Found");
                    }
                    else
                    {
                        Register model = new Register();
                        model.EditUser(obj);
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, "updated Successfully");
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }
        }

        public HttpResponseMessage GetCustomer(int id)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.Customers.Any(m => m.customerId == id);
                    if (!checkingData)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Customer Not Found");
                    }
                    else
                    {
                        Register model = new Register();
                        RegisterViewModel data = model.GetUser(id);
                        return Request.CreateResponse(HttpStatusCode.OK, data);
                    }
                    
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }
        }

        public HttpResponseMessage GetCustomerList()
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.Customers.Any();
                    if (!checkingData)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "No Customers");
                    }
                    else
                    {
                        Register model = new Register();
                        List<RegisterViewModel> dataList = model.GetUserList();
                        return Request.CreateResponse(HttpStatusCode.OK, dataList);
                    }

                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }
        }

    }
}

