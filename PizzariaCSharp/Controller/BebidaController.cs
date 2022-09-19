using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class BebidaController : ICrudController<Bebida>
    {
        private ICrudRepository<Bebida> _bebidaRepository;

        public BebidaController(ICrudRepository<Bebida> bebidaRepository)
        {
            _bebidaRepository = bebidaRepository;
        }

        public List<Bebida> ObterTodos()
        {
            return _bebidaRepository.ObterTodos();
        }

        public Bebida ObterPorId(int id)
        {
            return _bebidaRepository.ObterPorId(id);
        }

        public Bebida Adicionar(Bebida bebida)
        {
            return _bebidaRepository.Adicionar(bebida);
        }

        public void Deletar(int id)
        {
            _bebidaRepository.Deletar(id);
        }

        public Bebida Atualizar(int id, Bebida bebida)
        {
            bebida.Id = id;
            return _bebidaRepository.Atualizar(bebida);
        }
    }
}