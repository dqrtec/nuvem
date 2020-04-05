using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class Usuario
    {
        public string nome { get; set; }
        public string apelido { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string urlFoto { get; set; }
        public string Foto { get; set; }

        public string toString(){
            return this.nome+" = "+this.senha + " = " + Foto;
        }
    }
}