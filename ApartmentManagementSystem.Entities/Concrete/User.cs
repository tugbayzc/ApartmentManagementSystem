using ApartmentManagementSystem.Core.Entities;
using ApartmentManagementSystem.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace ApartmentManagementSystem.Entities.Concrete
{
    public class User: IEntity

    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; } 
        public string NationalityNo { get; set; }
        public string PhoneNumber { get; set; }
        public string LicensePlateNumber { get; set; }
    }
}
