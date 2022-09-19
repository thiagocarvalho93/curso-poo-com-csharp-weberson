namespace HotelCSharp.Interfaces
{
    public interface IGerente : ICamareira, IRecepcionista, IPessoa
    {
        public void conhecerMuitoBemOHotel();
    }
}