using HotelCSharp.Models;

namespace HotelCSharp.Interfaces
{
    public interface IRHTerceirizado
    {
        void contratarCamareira(ICamareira camareira);
        void contratarRecepcionista(IRecepcionista recepcionista);
        void promoverParaGerente(Camareira camareira);
        void promoverParaGerente(Recepcionista recepcionista);
    }
}