using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Camareira : Pessoa, ICamareira
    {
        public Camareira() : base()
        {
        }

        public Camareira(string nome, string cPF, string telefone) : base(nome, cPF, telefone)
        {
        }

        public void ArrumarCama()
        {
            System.Console.WriteLine("Sei arrumar a cama");
        }

        public void LimparQuarto()
        {
            System.Console.WriteLine("Sei limpar o quarto");
        }

        public override void SeApresentar()
        {
            System.Console.WriteLine("Sou a camareira " + Nome);
        }
    }
}