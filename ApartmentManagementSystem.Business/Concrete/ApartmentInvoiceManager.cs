using ApartmentManagementSystem.API.Entities.Concrete;
using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.DataAccess.Context;
using ApartmentManagementSystem.Entities.DTOs;
using ApartmentManagementSystem.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class ApartmentInvoiceManager : IApartmentInvoiceService
    {
        AppDbContext _context;

        public ApartmentInvoiceManager(AppDbContext context)
        {
            _context = context;
        }

        public void AddApartmentInvoicesInfo(ApartmentInvoice apartmentInvoice)
        {
            _context.ApartmentInvoices.Add(apartmentInvoice);
            _context.SaveChanges();
        }

        public IEnumerable<ApartmentInvoice> GetApartmentInvocesInfo(bool isPaid)
        {
            return _context.ApartmentInvoices.Where(x => x.IsPaid == isPaid).ToList();
        }

        public IQueryable<UserInvoicesDto> GetUserInvoices(int apartmentId)
        {
            var result = from ai in _context.ApartmentInvoices
                         join i in _context.Invoices
                         on ai.InvoiceId equals i.InvoiceId
                         where ai.ApartmentId == apartmentId
                         select new UserInvoicesDto
                         {UserId= ai.UserId, ApartmentId= ai.ApartmentId,
                         IsPaid= ai.IsPaid,InvoiceMonth=ai.InvoiceMonth, DueDate= ai.DueDate, InvoiceType = i.InvoiceType,
                         InvoicePrice=i.InvoicePrice
                         };
            return result;
        }
    }
}
