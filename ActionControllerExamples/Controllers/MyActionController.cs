using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionControllerExamples.Controllers
{
    [Route("api/MyActionCotrollers")]
    [ApiController]
    public class MyActionController : ControllerBase
    {
        [Route("GetDetails")]
        [HttpGet]
        [LogFilter]
        [ResultFilter]

        public dynamic GetMyDetails()
        {
            return (new
            {
                Name = "Dilip",
                Age = 24,
                Qulaification = "B-Tech"
            });
        }
        [Route("Exception")]
        [HttpGet]
        [ExceptionFilter]

        public string GetException()
        {
            throw new Exception("Exception Occur");
        }

    }
}