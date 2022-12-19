using ApartmentManagementSystem.API.Entities.Concrete;
using ApartmentManagementSystem.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IApartmentInvoiceService
    {
        void AddApartmentInvoicesInfo(ApartmentInvoice apartmentInvoice);
        IEnumerable<ApartmentInvoice> GetApartmentInvocesInfo(bool isPaid);//bun metot yaz
        IQueryable<UserInvoicesDto> GetUserInvoices(int apartmentId);
    }
}
