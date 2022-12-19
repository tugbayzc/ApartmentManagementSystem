using ApartmentManagementSystem.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace ApartmentManagementSystem.API.Entities.Concrete
{
    public class Message :IEntity
    {
        [Key]
        public int MessageId { get; set; }
        public int UserId { get; set; }
        public bool IsRead { get; set; } = false; 
        public string Content { get; set; }
        public DateTime SentDate { get; set; }
    }
}
