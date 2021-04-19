using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BLL
{
    interface IProduct
    {
        string AddProduct(ProductViewModel obj);
        string EditProductr(ProductViewModel obj);
        string DeleteProduct(int id);
        List<ProductViewModel> GetProductList();
    }
}
