using Agenda.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        [HttpGet("")]
        public string GetAll() 
        {
            return "Olá mundo";
        }
    }
}
