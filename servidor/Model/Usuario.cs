using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Usuario
    {
        public string nome { get; set; }
        [Key]
        public string apelido { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string Foto { get; set; }

        public string toString(){
            return this.nome+" = "+this.senha + " = "+Foto;
        }
    }
}