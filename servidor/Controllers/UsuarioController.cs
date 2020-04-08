using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Model;
using Repository;
using Contexto;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System.Text;
using System.IO;

using Amazon.RDS;
using Amazon.RDS.Model;

using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace servidor.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        public UsuarioController(){}

        [HttpGet]
        [Route("vivo")]
        public string isAlive(){
            return "Eu estou vivo";
        }

        [HttpPost]
        [Route("cadastrar")]
        public Boolean PostCadastrarUsuario(Usuario usuario){
            bool existeUsuario = false;
            if(!existeUsuario){
                salvarUsuario(usuario);
                salvarFoto(usuario);
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
    
        void salvarUsuario(Usuario usuario)
        {
            using (var db = new UsuarioContext())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }
        void salvarFoto(Usuario usuario)
        {
            var s3 = new AmazonS3Client(RegionEndpoint.USEast1);

            string key= usuario.apelido;
            string bucketName = "fotosperfilcompartilhagram";

            FileStream i = System.IO.File.OpenRead("img1");
            MemoryStream ms = new MemoryStream();

            byte[] bytes = new byte[i.Length];
            i.Read(bytes, 0, (int)i.Length);
            Console.WriteLine(bytes);
            ms.Write(bytes, 0, (int)i.Length);

            var req = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                InputStream = ms
            };

            Task<PutObjectResponse> res = s3.PutObjectAsync(req);
            Task.WaitAll(res);
        }
    }

}
