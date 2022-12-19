using ApartmentManagementSystem.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs
{
    public class UserInvoicesDto
    {
        public int UserId { get; set; }
        public int ApartmentId { get; set; }
        public InvoiceType InvoiceType { get; set; }
        public float InvoicePrice { get; set; }
        public bool IsPaid { get; set; }
        public Month InvoiceMonth { get; set; }
        public DateTime DueDate { get; set; }
    }
}
