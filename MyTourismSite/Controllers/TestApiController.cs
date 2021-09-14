using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTourismSite.Controllers
{
    [Route("api/shoudongapi")]

    //[Controller]
    //ShoudongAPIController
    public class ShoudongAPI:ControllerBase
    {
        [HttpGet]
        public String Get() => "xixi";

    }
}
