
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiAngel.Entidades;

namespace WebApiAngel.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>(){
                new Autor(){Id=1,Nombre="Angel"},
                new Autor(){Id=2, Nombre="Clau"}
            };
        }
    }
}