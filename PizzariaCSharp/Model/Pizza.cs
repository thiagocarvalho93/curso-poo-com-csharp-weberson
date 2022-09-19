
using PizzariaCSharp.Enums;

namespace PizzariaCSharp.Model
{
    public class Pizza
    {
        public int Id { get; set; }
        public ETipoPizza Tipo { get; set; }
        public ETipoBorda TipoBorda { get; set; }
        public List<Sabor> Sabores { get; set; }
        public double Valor { get; set; }

        public Pizza(ETipoPizza tipo, ETipoBorda tipoBorda, List<Sabor> sabores, double valor)
        {
            Tipo = tipo;
            TipoBorda = tipoBorda;
            Sabores = sabores;
            Valor = valor;
        }
    }
}