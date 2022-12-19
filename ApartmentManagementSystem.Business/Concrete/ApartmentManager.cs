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
    public class ApartmentManager : IApartmentService
    {
        public AppDbContext _context { get; }

        public ApartmentManager(AppDbContext context)
        {
            _context = context;
        }

        public void AddApartmentInfo(Apartment apartment)
        {
            _context.Apartments.Add(apartment);
            _context.SaveChanges();
        }

        public void DeleteApartmentInfoById(int apartmentId)
        {
            var deletedApartment = _context.Apartments.Where(x => x.ApartmentId== apartmentId).FirstOrDefault();
            _context.Apartments.Remove(deletedApartment);
            _context.SaveChanges();
        }

        public List<Apartment> GetApartmentsInfo()
        {
            return _context.Apartments.ToList();
           
        }

        public void UpdateApartmentInfo(Apartment apartment)
        {
            _context.Apartments.Update(apartment);
            _context.SaveChanges();
        }
    }
}
