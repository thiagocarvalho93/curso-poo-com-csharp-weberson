
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class ClienteController : ICrudController<Cliente>
    {
        private ICrudRepository<Cliente> _clienteRepository;

        public ClienteController(ICrudRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Adicionar(Cliente modelo)
        {
            return _clienteRepository.Adicionar(modelo);
        }

        public Cliente Atualizar(int id, Cliente modelo)
        {
            modelo.Id = id;
            return _clienteRepository.Atualizar(modelo);
        }

        public void Deletar(int id)
        {
            _clienteRepository.Deletar(id);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public List<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }
    }
}