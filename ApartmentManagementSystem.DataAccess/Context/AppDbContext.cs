using ApartmentManagementSystem.API.Entities.Concrete;
using ApartmentManagementSystem.Entities.Concrete;
using ApartmentManagementSystem.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ApartmentInvoice> ApartmentInvoices { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Invoice> Invoices { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-EGA7D2D; Database=ApartmentDb; Trusted_Connection=True;");
        //}
    }
}
