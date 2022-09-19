using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PizzaRepository : ICrudRepository<Pizza>
    {
        private List<Pizza> _pizzas;
        private int _ultimoId = 0;

        public PizzaRepository()
        {
            _pizzas = new List<Pizza>();
        }
        public Pizza Adicionar(Pizza modelo)
        {
            _ultimoId++;
            modelo.Id = _ultimoId;

            _pizzas.Add(modelo);

            return modelo;
        }

        public Pizza Atualizar(Pizza modelo)
        {
            var modeloEncontrado = ObterPorId(modelo.Id);

            _pizzas.Remove(modeloEncontrado);
            _pizzas.Add(modelo);

            return modelo;
        }

        public void Deletar(int id)
        {
            var pizza = ObterPorId(id);

            _pizzas.Remove(pizza);
        }

        public Pizza ObterPorId(int id)
        {
            if (_pizzas.Any(b => b.Id == id))
            {
                return _pizzas
                    .Where(b => b.Id == id)
                    .First();
            }
            throw new Exception("Não encontrado");
        }

        public List<Pizza> ObterTodos()
        {
            return _pizzas;
        }
    }
}