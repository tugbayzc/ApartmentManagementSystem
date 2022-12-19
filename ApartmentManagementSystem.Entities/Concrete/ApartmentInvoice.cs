using ApartmentManagementSystem.Core.Entities;
using ApartmentManagementSystem.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;
namespace ApartmentManagementSystem.API.Entities.Concrete
{
    public class ApartmentInvoice :IEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ApartmentId { get; set; }
        public int InvoiceId { get; set; }
        public bool IsPaid { get; set; }
        public Month InvoiceMonth { get; set; }
        public DateTime DueDate { get; set; }
    }
}
