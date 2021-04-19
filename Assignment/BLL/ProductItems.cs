using Assignment.DAL;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment.BLL
{
    public class ProductItems : IProduct
    {
        public string AddProduct(ProductViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    Product pro = new Product();
                    pro.productName = obj.productName;
                    pro.code = obj.code;
                    pro.productDescription = obj.productDescription;
                    pro.stockQuantity = obj.stockQuantity;
                    pro.updatedDate = pro.createdDate = DateTime.Now;
                    pro.isStatus = true;
                    db.Products.Add(pro);
                    db.SaveChanges();
                    return "Ok";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string DeleteProduct(int id)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    Product cus = db.Products.Where(m => m.productId == id).FirstOrDefault();
                    cus.isStatus = false;
                    db.SaveChanges();
                    return "Ok";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string EditProductr(ProductViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    // Customer 
                    Product pro = db.Products.Where(m => m.productId == obj.productId).FirstOrDefault();
                    pro.productName = obj.productName;
                    pro.code = obj.code;
                    pro.productDescription = obj.productDescription;
                    pro.stockQuantity = obj.stockQuantity;
                    pro.updatedDate =  DateTime.Now;
                    return "OK";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProductViewModel> GetProductList()
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var allList = db.Products.Where(m => m.isStatus == true).ToList();
                    List<ProductViewModel> allResultList = new List<ProductViewModel>();
                    foreach (var item in allList)
                    {
                        ProductViewModel dataResult = new ProductViewModel();
                        dataResult.productName = item.productName;
                        dataResult.code = item.code;
                        dataResult.productDescription = item.productDescription;
                        dataResult.stockQuantity = item.stockQuantity;
                        dataResult.updatedDate =  DateTime.Now;
                        allResultList.Add(dataResult);
                    }

                    return allResultList;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}