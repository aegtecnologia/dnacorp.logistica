using Interage.Logistica.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Interage.Logistica.Api.Controllers
{
    [Route("ecoporto-api/json/viagem")]
    public class ViagemController : ApiController
    {
        [HttpPost]
        [Route("register")]
        public RegistrarViagemTraResponse RegistrarViagemTRA(RegistrarViagemTraRequest request)
        {
            return new RegistrarViagemTraResponse()
            {
                error = false,
                msg_error = "",
                rowCount = 0,
                viagem_id = "123456"
            };
        }
    }
}
