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
    public class UserRetriveController : Controller, ISampleService
    {
        [HttpGet("GetAllUser")]
        public List<Users> GetAllUser()
        {
            return Registration.getInstance().getAllUser();
        }
        [HttpGet("GetAllUserData")]
        public JsonResult GetAllUserData()
        {
            return Json(Registration.getInstance().getAllUser());
        }

        [HttpGet("GetAllUserlist")]
        public List<Users> GetAllUserlist()
        {
            return Registration.getInstance().getAllUser();
        }
    }
}
