using ApartmentManagementSystem.API.Entities.Concrete;
using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Entities.Concrete;
using ApartmentManagementSystem.Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IInvoiceService _ınvoiceService;
        private readonly IApartmentInvoiceService _apartmentInvoiceService;
        private readonly IUserService _userService;
        private readonly IApartmentService _apartmentService;
        private readonly ITokenService _tokenService;
        public AdminController(IApartmentService apartmentService, ITokenService tokenService, IUserService userService, IApartmentInvoiceService apartmentInvoiceService, IInvoiceService ınvoiceService, IMessageService messageService)
        {
            _apartmentService = apartmentService;
            _tokenService = tokenService;
            _userService = userService;
            _apartmentInvoiceService = apartmentInvoiceService;
            _ınvoiceService = ınvoiceService;
            _messageService = messageService;
        }


        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate(UserDto user)
        {
            var token = _tokenService.Authenticate(user);
            if (token==null)
            {
                return Unauthorized("Yetkisiz giriş");
            }
            return Ok(token);
        }

        [HttpPost("AddApartmentDetails")]
        public IActionResult AddApartmentInfo(Apartment apartment)
        {
            _apartmentService.AddApartmentInfo(apartment);
            return Ok();
        }

        [HttpPost("AddUserInfo")]
        public IActionResult AddUserDetails(User user)
        {
            _userService.AddUserInfo(user);
            return Ok();
        }

        [HttpPost("AddInvoicesInfo")]
        public IActionResult AddInvoicesInfo(Invoice invoice)
        {
            _ınvoiceService.AddInvoiceInfo(invoice);
            return Ok();
        }

        [HttpPost("AddApartmentInvoicesInfo")]
        public IActionResult AddApartmentInvoicesInfo(ApartmentInvoice apartmentInvoice)
        {
           _apartmentInvoiceService.AddApartmentInvoicesInfo(apartmentInvoice);

            return Ok();
        }
        [HttpGet("GetApartmentInvocesInfoByPaymentStatus")]
        public IActionResult GetApartmentInvocesInfoByPaymentStatus(bool isPaid)
        {
            var result =_apartmentInvoiceService.GetApartmentInvocesInfo(isPaid);
            return Ok(result);
        }

        [HttpGet("GetMessages")]
        public IActionResult GetMessages()
        {
            var result = _messageService.GetMessages();
            return Ok(result);
        }

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            var result = _userService.GetUsers();
            return Ok(result);
        }

        [HttpDelete("DeleteUserById")]
        public IActionResult DeleteUserById(int userId)
        {
            _userService.DeleteUserById(userId);
            return Ok();
        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            _userService.UpdateUser(user);
            return Ok();
        }
        [HttpGet("GetApartments")]
        public IActionResult GetApartments()
        {
            var result = _apartmentService.GetApartmentsInfo();
            return Ok(result);
        }

        [HttpDelete("DeleteApartment")]
        public IActionResult DeleteApartment(int apartmentId)
        {
            _apartmentService.DeleteApartmentInfoById(apartmentId);
            return Ok();
        }

        [HttpPut("UpdateApartment")]
        public IActionResult UpdateApartment(Apartment apartment)
        {
            _apartmentService.UpdateApartmentInfo(apartment);
            return Ok();
        }

    }
}
