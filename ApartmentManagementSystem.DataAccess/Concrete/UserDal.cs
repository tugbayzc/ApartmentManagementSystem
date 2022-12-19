using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Concrete
{
    public class UserDal: EntityRepositoryBase<User>,IUserDal
    {
    }
}
