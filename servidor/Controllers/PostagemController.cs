using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Model;

namespace servidor.Controllers
{
    [ApiController]
    [Route("api/postagem")]
    public class PostagemController : ControllerBase
    {
        private readonly ILogger<PostagemController> _logger;

        public PostagemController(ILogger<PostagemController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("postar")]
        public Boolean PostCriarPostagem(Postagem postagem){
            try
            {
                //criar Postagem()
                Console.WriteLine( postagem.toString() );
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return false;
        }
    }
}
