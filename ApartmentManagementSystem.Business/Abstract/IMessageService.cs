using ApartmentManagementSystem.API.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IMessageService
    {
        List<Message> GetMessages();
        void SendMessageToAdmin(Message message);
    }
}
