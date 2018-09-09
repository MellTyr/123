using System;
using System.Linq;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Push.v1.Controllers {
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    [ApiController]
    public class DataController : ControllerBase {
        private readonly IUrlHelper _urlHelper;

        [HttpPost]
        public ActionResult PostData(string data)
        {
            var m = new Message();
            m.message = data;
            m.Send();
            return Ok("Message send!");
        }
    }
}
