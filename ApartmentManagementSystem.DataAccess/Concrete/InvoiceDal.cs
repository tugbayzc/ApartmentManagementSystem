using ApartmentManagementSystem.API.Entities.Concrete;
using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Concrete
{
    public class InvoiceDal : EntityRepositoryBase<Invoice>,IInvoiceDal
    {
    }
}
