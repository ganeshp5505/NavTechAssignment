using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BLL
{
    interface IRegisterUsers
    {
        string AddUser(RegisterViewModel obj);
        string EditUser(RegisterViewModel obj);
        string DeleteUser(int id);
        RegisterViewModel GetUser(int id);
        List<RegisterViewModel> GetUserList();
    }
}
