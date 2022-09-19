using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class PizzaController : ICrudController<Pizza>
    {
        private ICrudRepository<Pizza> _pizzaRepository;

        public PizzaController(ICrudRepository<Pizza> pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        public Pizza Adicionar(Pizza modelo)
        {
            return _pizzaRepository.Adicionar(modelo);
        }

        public Pizza Atualizar(int id, Pizza modelo)
        {
            modelo.Id = id;
            return _pizzaRepository.Atualizar(modelo);
        }

        public void Deletar(int id)
        {
            _pizzaRepository.Deletar(id);
        }

        public Pizza ObterPorId(int id)
        {
            return _pizzaRepository.ObterPorId(id);
        }

        public List<Pizza> ObterTodos()
        {
            return _pizzaRepository.ObterTodos();
        }
    }
}