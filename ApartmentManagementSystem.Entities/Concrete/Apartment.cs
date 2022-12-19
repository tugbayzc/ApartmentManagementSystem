using ApartmentManagementSystem.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ApartmentManagementSystem.API.Entities.Concrete
{
    public class Apartment :IEntity 
    {
        [Key]
        public int ApartmentId { get; set; }
        public int UserId { get; set; }
        public int ApartmentNumber { get; set; }
        public char Block { get; set; }
        public int Floor { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; } 
    }
}
