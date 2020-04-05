using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Model;
using Repository;
using Contexto;

namespace servidor.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private IUsuarioRepository usuarioRepository;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            this.usuarioRepository = new UsuarioRepository( new UsuarioContext());
            _logger = logger;
        }

        [HttpGet]
        [Route("vivo")]
        public string isAlive(){
            return "Eu estou vivo";
        }

        /* json surportado
        {
        	"nome" : "",
            "apelido" : "",
            "senha" : "",
            "email" : "",
            "urlFoto" : "",
            "Foto" : ""
        }*/
        [HttpPost]
        [Route("cadastrar")]
        public Boolean PostCadastrarUsuario(Usuario usuario){
            bool existeUsuario = false;
            if(!existeUsuario){
                // operacao de cadastro de ususario()
                return true;
            }
            return false;
        }

        [HttpPut]
        [Route("atualizar")]
        public Boolean PutAtualizarDados(Usuario usuario){
            try
            {
                //atualizarUsuario()
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return false;
        }
    }
}
