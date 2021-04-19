using Assignment.DAL;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.BLL
{
    public class Register : IRegisterUsers
    {
        public string AddUser(RegisterViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    Customer cus = new Customer();
                    cus.customername = obj.customername;
                    cus.emailId = obj.emailId;
                    cus.customerAddress = obj.customerAddress;
                    cus.gender = obj.gender;
                    cus.mobileNumber = obj.mobileNumber;
                    cus.updatedDate = cus.createdDate =DateTime.Now;
                    cus.isStatus = true;
                    db.Customers.Add(cus);
                    db.SaveChanges();
                    return "Ok";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string DeleteUser(int id)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    Customer cus = db.Customers.Where(m => m.customerId == id).FirstOrDefault();
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

        public string EditUser(RegisterViewModel obj)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    // Customer 
                    Customer cus = db.Customers.Where(m => m.customerId == obj.customerId).FirstOrDefault();
                    cus.customername = obj.customername;
                    cus.emailId = obj.emailId;
                    cus.customerAddress = obj.customerAddress;
                    cus.gender = obj.gender;
                    cus.mobileNumber = obj.mobileNumber;
                    cus.updatedDate = DateTime.Now;
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public RegisterViewModel GetUser(int id)
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    Customer cus = db.Customers.Where(m => m.customerId == id).FirstOrDefault();
                    RegisterViewModel dataResult = new RegisterViewModel();
                    dataResult.customerAddress = cus.customerAddress;
                    dataResult.customername = cus.customername;
                    dataResult.gender = cus.gender;
                    dataResult.emailId = cus.emailId;
                    dataResult.mobileNumber = cus.mobileNumber;
                    dataResult.createdDate = cus.createdDate;

                    return dataResult;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<RegisterViewModel> GetUserList()
        {
            try
            {
                using (NavAssignmentEntities db = new NavAssignmentEntities())
                {
                    var allList = db.Customers.Where(m => m.isStatus == true).ToList();
                    List<RegisterViewModel> allResultList = new List<RegisterViewModel>();
                    foreach (var item in allList)
                    {
                        RegisterViewModel dataResult = new RegisterViewModel();
                        dataResult.customerAddress = item.customerAddress;
                        dataResult.customername = item.customername;
                        dataResult.gender = item.gender;
                        dataResult.emailId = item.emailId;
                        dataResult.mobileNumber = item.mobileNumber;
                        dataResult.createdDate = item.createdDate;
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