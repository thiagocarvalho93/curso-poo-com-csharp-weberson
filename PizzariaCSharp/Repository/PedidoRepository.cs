using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PedidoRepository : ICrudRepository<Pedido>
    {
        private List<Pedido> _pedidos;
        private int _ultimoId = 0;

        public PedidoRepository()
        {
            _pedidos = new List<Pedido>();
        }
        public Pedido Adicionar(Pedido modelo)
        {
            _ultimoId++;
            modelo.Id = _ultimoId;

            _pedidos.Add(modelo);

            return modelo;
        }

        public Pedido Atualizar(Pedido modelo)
        {
            var modeloEncontrado = ObterPorId(modelo.Id);

            _pedidos.Remove(modeloEncontrado);
            _pedidos.Add(modelo);

            return modelo;
        }

        public void Deletar(int id)
        {
            var pedido = ObterPorId(id);

            _pedidos.Remove(pedido);
        }

        public Pedido ObterPorId(int id)
        {
            if (_pedidos.Any(b => b.Id == id))
            {
                return _pedidos
                    .Where(b => b.Id == id)
                    .First();
            }
            throw new Exception("Não encontrado");
        }

        public List<Pedido> ObterTodos()
        {
            return _pedidos;
        }
    }
}