using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Gerente : Pessoa, IGerente
    {
        public Gerente()
        {
        }

        public Gerente(string nome, string cPF, string telefone) : base(nome, cPF, telefone)
        {
        }

        public void ArrumarCama()
        {
            System.Console.WriteLine("Sou o gerente e sei arrumar a cama");
        }

        public void AtenderTelefone()
        {
            System.Console.WriteLine("Sou gerente e sei atender o telefone");
        }

        public void conhecerMuitoBemOHotel()
        {
            System.Console.WriteLine("Sou gerente e conheço muito bem o Hotel");
        }

        public void FalarIngles()
        {
            System.Console.WriteLine("Sou gerente e sei falar inglês");
        }

        public void LimparQuarto()
        {
            System.Console.WriteLine("Sou gerente e sei limpar o quarto");
        }

        public override void SeApresentar()
        {
            System.Console.WriteLine("Sou o gerente " + Nome);
        }
    }
}