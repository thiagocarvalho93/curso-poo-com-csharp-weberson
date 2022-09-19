using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelCSharp.Models
{
    public class Endereco
    {
        public String CEP { get; set; }
        public String Rua { get; set; }
        public int Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
    }
}