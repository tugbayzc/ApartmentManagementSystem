using ApartmentManagementSystem.API.Entities.Concrete;
using ApartmentManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IUserService
    {
        void AddUserInfo(User user);
        List<User> GetUsers();
        void UpdateUser(User user);
        void DeleteUserById(int userId);

        
    }
}
