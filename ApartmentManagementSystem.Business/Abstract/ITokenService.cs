using ApartmentManagementSystem.Entities.Concrete;
using ApartmentManagementSystem.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface ITokenService
    {
        TokenDto Authenticate(UserDto user);
    }
}
