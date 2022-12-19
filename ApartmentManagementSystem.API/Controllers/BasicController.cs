using ApartmentManagementSystem.API.Entities.Concrete;
using ApartmentManagementSystem.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IApartmentInvoiceService _apartmentInvoiceService;

        public BasicController(IApartmentInvoiceService apartmentInvoiceService, IMessageService messageService)
        {
            _apartmentInvoiceService = apartmentInvoiceService;
            _messageService = messageService;
        }

        [HttpGet("GetUserInvoiceInfo")]
        public IActionResult GetUserInvoiceInfo(int apartmentId)
        {
            var result = _apartmentInvoiceService.GetUserInvoices(apartmentId);
            return Ok(result);
        }

        [HttpPost("SendMessageToAdmin")]
        public IActionResult SendMessageToAdmin(Message message)
        {
            _messageService.SendMessageToAdmin(message);
            return Ok();
        }
    }
}
