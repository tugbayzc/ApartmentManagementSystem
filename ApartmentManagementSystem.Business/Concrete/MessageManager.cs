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
    public class MessageManager : IMessageService
    {
        AppDbContext _context;

        public MessageManager(AppDbContext context)
        {
            _context = context;
        }

        public List<Message> GetMessages()
        {
            return _context.Messages.ToList();
        }


        public void SendMessageToAdmin(Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
    }
}
