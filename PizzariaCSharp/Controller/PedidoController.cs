
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class PedidoController : ICrudController<Pedido>
    {
        private ICrudRepository<Pedido> _pedidoRepository;

        public PedidoController(ICrudRepository<Pedido> pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        
        public Pedido Adicionar(Pedido modelo)
        {
            return _pedidoRepository.Adicionar(modelo);
        }

        public Pedido Atualizar(int id, Pedido modelo)
        {
            modelo.Id = id;
            return _pedidoRepository.Atualizar(modelo);
        }

        public void Deletar(int id)
        {
            _pedidoRepository.Deletar(id);
        }

        public Pedido ObterPorId(int id)
        {
            return _pedidoRepository.ObterPorId(id);
        }

        public List<Pedido> ObterTodos()
        {
            return _pedidoRepository.ObterTodos();
        }
    }
}