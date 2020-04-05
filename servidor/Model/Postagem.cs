using Model;

namespace Model
{
    public class Postagem
    {
        public Usuario usuario { get; set; }
        public string foto { get; set; }
        public string urlFoto { get; set; }
        public string quantidadeCurtida { get; set; }
        public string descricao { get; set; }

        public string toString(){
            return this.usuario.apelido +" = "+this.descricao;
        }
    }
}