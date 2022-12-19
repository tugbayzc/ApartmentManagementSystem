using ApartmentManagementSystem.API.Entities.Concrete;
using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class InvoiceManager : IInvoiceService
    {
        AppDbContext _context;

        public InvoiceManager(AppDbContext context)
        {
            _context = context;
        }

        public void AddInvoiceInfo(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }
    }
}
