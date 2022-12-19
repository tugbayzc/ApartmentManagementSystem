using ApartmentManagementSystem.API.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IInvoiceService
    {
        void AddInvoiceInfo(Invoice invoice);
        
    }
}
