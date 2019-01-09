using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationController : Controller
    {
        // POST: api/<controller>
        [HttpPost]
        public RegistrationReply RegisterUser(Users Userregd)
        {
            Console.WriteLine("In register");
            RegistrationReply stdregreply = new RegistrationReply();
            Registration.getInstance().Add(Userregd);
            stdregreply.FirstName = Userregd.FirstName;
            stdregreply.LastName = Userregd.LastName;
            stdregreply.RegistrationNumber = Userregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";
            return stdregreply;
        }
        [HttpPost("InsertUser")]
        public IActionResult InsertUser(Users Userregd)
        {
            Console.WriteLine("In register");
            RegistrationReply stdregreply = new RegistrationReply();
            Registration.getInstance().Add(Userregd);
            stdregreply.FirstName = Userregd.FirstName;
            stdregreply.LastName = Userregd.LastName;
            stdregreply.RegistrationNumber = Userregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";
            return Ok(stdregreply);
        }
        [Route("user/")]
        [HttpPost("AddUser")]
        public JsonResult AddUser(Users Userregd)
        {
            Console.WriteLine("In register");
            RegistrationReply stdregreply = new RegistrationReply();
            Registration.getInstance().Add(Userregd);
            stdregreply.FirstName = Userregd.FirstName;
            stdregreply.LastName = Userregd.LastName;
            stdregreply.RegistrationNumber = Userregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";
            return Json(stdregreply);
        }
    }
}
