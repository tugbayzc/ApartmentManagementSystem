using ApartmentManagementSystem.API.Entities.Concrete;
using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.DataAccess.Context;
using ApartmentManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class UserManager : IUserService
    {
        AppDbContext _context;

        public UserManager(AppDbContext context)
        {
            _context = context;
        }

        public void AddUserInfo(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUserById(int userId)
        {
            var deletedUser = _context.Users.Where(x => x.UserId == userId).FirstOrDefault();
            _context.Users.Remove(deletedUser);
            _context.SaveChanges();
        }


        public List<User> GetUsers()
        {
            return _context.Users.ToList();
           
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
