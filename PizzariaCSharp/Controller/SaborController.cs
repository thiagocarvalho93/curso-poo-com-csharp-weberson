
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class SaborController : ICrudController<Sabor>
    {
        private ICrudRepository<Sabor> _saborRepository;

        public SaborController(ICrudRepository<Sabor> saborRepository)
        {
            _saborRepository = saborRepository;
        }

        public Sabor Adicionar(Sabor modelo)
        {
            return _saborRepository.Adicionar(modelo);
        }

        public Sabor Atualizar(int id, Sabor modelo)
        {
            modelo.Id = id;
            return _saborRepository.Atualizar(modelo);
        }

        public void Deletar(int id)
        {
            _saborRepository.Deletar(id);
        }

        public Sabor ObterPorId(int id)
        {
            return _saborRepository.ObterPorId(id);
        }

        public List<Sabor> ObterTodos()
        {
            return _saborRepository.ObterTodos();
        }
    }
}