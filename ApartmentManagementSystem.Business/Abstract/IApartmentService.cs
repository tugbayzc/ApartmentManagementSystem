using ApartmentManagementSystem.API.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IApartmentService
    {
        void AddApartmentInfo(Apartment apartment);
        List<Apartment> GetApartmentsInfo();
        void UpdateApartmentInfo(Apartment apartment);
        void DeleteApartmentInfoById(int apartmentId);

    }
}
