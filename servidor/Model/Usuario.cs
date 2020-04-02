namespace Model.Usuario
{
    public class Usuario
    {
        public string nome { get; set; }
        public string senha { get; set; }

        public string toString(){
            return this.nome+" = "+this.senha;
        }
    }
}