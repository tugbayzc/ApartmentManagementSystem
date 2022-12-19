using ApartmentManagementSystem.Core.Entities;
using ApartmentManagementSystem.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;


namespace ApartmentManagementSystem.API.Entities.Concrete
{
    public class Invoice  :IEntity
    {
        [Key]
        public int InvoiceId { get; set; }
        public InvoiceType InvoiceType { get; set; }
        public float InvoicePrice { get; set; }
        
    }
}
