using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public class Carro
    {
        #region Atributos
        public string? Cor { get; set; }
        public string? Modelo { get; set; }
        public int? Ano { get; set; }
        #endregion

        #region Construtores
        public Carro()
        {

        }
        public Carro(string cor, string modelo, int ano)
        {
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }
        #endregion

        #region Métodos
        public void LigarCarro()
        {
            Console.WriteLine("Ligando o carro...");
            Console.WriteLine(Modelo + " ligado.");
        }

        public void Buzinar()
        {
            Console.WriteLine("Bibi");
        }
        #endregion

    }
}