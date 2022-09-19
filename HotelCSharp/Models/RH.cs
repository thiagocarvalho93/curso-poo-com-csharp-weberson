using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class RH : IRHTerceirizado
    {

        #region Atributos
        public String Nome { get; set; }
        public Hotel Hotel { get; set; }
        #endregion

        #region Construtores
        public RH(string nome, Hotel hotel)
        {
            Nome = nome;
            Hotel = hotel;
        }
        #endregion

        #region Métodos
        public void contratarCamareira(ICamareira camareira)
        {
            Hotel.Camareiras.Add(camareira);
        }

        public void contratarRecepcionista(IRecepcionista recepcionista)
        {
            Hotel.Recepcionistas.Add(recepcionista);
        }

        public void promoverParaGerente(Camareira camareira)
        {
            if (camareira.CPF == null)
            {
                throw new DocumentosInvalidosException("Regularize seu CPF para receber a promoção");
            }
            Hotel.contratarGerente(new Gerente()
            {
                Nome = camareira.Nome,
                CPF = camareira.CPF,
                Telefone = camareira.Telefone
            });
        }

        public void promoverParaGerente(Recepcionista recepcionista)
        {
            if (recepcionista.CPF == null)
            {
                throw new DocumentosInvalidosException("Regularize seu CPF para receber a promoção");
            }
            Hotel.contratarGerente(new Gerente()
            {
                Nome = recepcionista.Nome,
                CPF = recepcionista.CPF,
                Telefone = recepcionista.Telefone
            });
        }
        #endregion

    }
}