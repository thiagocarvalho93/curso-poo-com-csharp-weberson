using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class ClienteRepository : ICrudRepository<Cliente>
    {
        private List<Cliente> _clientes;
        private int _ultimoId = 0;

        public ClienteRepository()
        {
            _clientes = new List<Cliente>();
        }
        public Cliente Adicionar(Cliente modelo)
        {
            _ultimoId++;
            modelo.Id = _ultimoId;

            _clientes.Add(modelo);

            return modelo;
        }

        public Cliente Atualizar(Cliente modelo)
        {
            var modeloEncontrado = ObterPorId(modelo.Id);

            _clientes.Remove(modeloEncontrado);
            _clientes.Add(modelo);

            return modelo;
        }

        public void Deletar(int id)
        {
            var cliente = ObterPorId(id);

            _clientes.Remove(cliente);
        }

        public Cliente ObterPorId(int id)
        {
            if (_clientes.Any(b => b.Id == id))
            {
                return _clientes
                    .Where(b => b.Id == id)
                    .First();
            }
            throw new Exception("Não encontrado");
        }

        public List<Cliente> ObterTodos()
        {
            return _clientes;
        }
    }
}