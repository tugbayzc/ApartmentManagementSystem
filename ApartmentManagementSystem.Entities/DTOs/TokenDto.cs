using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs
{
    public class TokenDto
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
