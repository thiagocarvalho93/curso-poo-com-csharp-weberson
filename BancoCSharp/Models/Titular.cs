namespace BancoCSharp.Models
{
    public class Titular
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public Endereco? Endereco { get; set; }

        public Titular(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public Titular(string nome, string cpf, string telefone, Endereco endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}