namespace HotelCSharp.Models
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {
        }

        public Cliente(string nome, string cPF, string telefone) : base(nome, cPF, telefone)
        {
        }

        public override void SeApresentar()
        {
            throw new NotImplementedException();
        }
    }
}