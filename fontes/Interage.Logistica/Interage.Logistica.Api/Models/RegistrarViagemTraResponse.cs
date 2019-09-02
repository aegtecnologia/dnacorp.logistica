using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interage.Logistica.Api.Models
{
    public class RegistrarViagemTraResponse
    {
        public bool error { get; set; }
        public string msg_error { get; set; }
        public int rowCount { get; set; }
        public string viagem_id { get; set; }
    }
}