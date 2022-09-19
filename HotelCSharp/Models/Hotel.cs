using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Hotel
    {
        public String Nome { get; set; }
        public Endereco Endereco { get; private set; }
        public List<IRecepcionista> Recepcionistas { get; private set; }
        public List<ICamareira> Camareiras { get; private set; }
        public IGerente Gerente { get; private set; }

        public Hotel(String nome)
        {
            Nome = nome;
            Recepcionistas = new List<IRecepcionista>();
            Camareiras = new List<ICamareira>();
        }

        public Hotel(String nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Recepcionistas = new List<IRecepcionista>();
            Camareiras = new List<ICamareira>();
        }

        public void contratarGerente(IGerente gerente)
        {
            Gerente = gerente;
        }

        public void contratarCamareira(ICamareira camareira)
        {
            Camareiras.Add(camareira);
        }

        public void contratarRecepcionista(IRecepcionista recepcionista)
        {
            Recepcionistas.Add(recepcionista);
        }

    }
}