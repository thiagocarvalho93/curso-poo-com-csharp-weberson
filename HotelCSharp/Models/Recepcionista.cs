using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Recepcionista : Pessoa, IRecepcionista
    {
        public Recepcionista()
        {
        }

        public Recepcionista(string nome, string cPF, string telefone) : base(nome, cPF, telefone)
        {
        }

        public void AtenderTelefone()
        {
            System.Console.WriteLine("Sei atender o telefone");
        }

        public void FalarIngles()
        {
            System.Console.WriteLine("Sei falar inglês");
        }

        public override void SeApresentar()
        {
            System.Console.WriteLine("Prazer, sou a recepcionista " + Nome);
        }
    }
}