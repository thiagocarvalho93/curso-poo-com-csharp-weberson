using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public abstract class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        protected Pessoa()
        {
        }

        protected Pessoa(string nome, string cPF, string telefone)
        {
            Nome = nome;
            CPF = cPF;
            Telefone = telefone;
        }

        public virtual void SeApresentar()
        {
            System.Console.WriteLine("Sou a pessoa " + Nome);
        }
    }
}