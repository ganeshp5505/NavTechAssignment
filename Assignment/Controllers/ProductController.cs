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
    public class ProductController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage AddProduct(ProductViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.Products.Any(m => m.code == obj.code || m.productName == obj.productName);

                    if (checkingData)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Product already exists. Please try new");
                    }
                    else
                    {
                        ProductItems model = new ProductItems();
                        model.AddProduct(obj);
                    }

                }

            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }

            return Request.CreateResponse(HttpStatusCode.OK, "Added Successfully");
        }

        [HttpDelete]
        public HttpResponseMessage DeleteProduct(int id)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.Customers.Any(m => m.customerId == id);
                    if (!checkingData)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Product Not Found");
                    }
                    else
                    {
                        ProductItems model = new ProductItems();
                        model.DeleteProduct(id);
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted Successfully");
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }
        }

        [HttpPut]
        public HttpResponseMessage EditProduct(ProductViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.Products.Any(m => m.productId == obj.productId);
                    if (!checkingData)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Product Not Found");
                    }
                    else
                    {
                        ProductItems model = new ProductItems();
                        model.EditProductr(obj);
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, "updated Successfully");
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Somthing went wrong");
            }
        }

        [HttpGet]
        public HttpResponseMessage GetProductList()
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var checkingData = db.Customers.Any();
                    if (!checkingData)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "No Products");
                    }
                    else
                    {
                        ProductItems model = new ProductItems(); 
                        List<ProductViewModel> dataList = model.GetProductList();
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

