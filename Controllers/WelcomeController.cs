using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        private readonly WelcomeMessage _message;
        [HttpGet]
        public string SayHello() => _message.Message;

        public WelcomeController(WelcomeMessage message)
        {
            _message = message;
        }
    }
}
