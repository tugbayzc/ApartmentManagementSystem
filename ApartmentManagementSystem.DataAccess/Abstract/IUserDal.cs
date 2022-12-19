using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Abstract
{
    public interface IUserDal :IEntityRepository<User>
    {
    }
}
