using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Model.Usuario;

namespace servidor.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("vivo")]
        public string isAlive(Usuario usuario){
            Console.WriteLine(usuario.toString());
            return usuario.toString();
        }

        [HttpPost]
        public Boolean isUser(Usuario usuario)
        {
            Console.WriteLine(usuario.toString());
            return false;
        }
    }
}
