using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class SaborRepository : ICrudRepository<Sabor>
    {
        private List<Sabor> _sabores;
        private int _ultimoId = 0;

        public SaborRepository()
        {
            _sabores = new List<Sabor>();
        }
        public Sabor Adicionar(Sabor modelo)
        {
            _ultimoId++;
            modelo.Id = _ultimoId;

            _sabores.Add(modelo);

            return modelo;
        }

        public Sabor Atualizar(Sabor modelo)
        {
            var modeloEncontrado = ObterPorId(modelo.Id);

            _sabores.Remove(modeloEncontrado);
            _sabores.Add(modelo);

            return modelo;
        }

        public void Deletar(int id)
        {
            var sabor = ObterPorId(id);

            _sabores.Remove(sabor);
        }

        public Sabor ObterPorId(int id)
        {
            if (_sabores.Any(b => b.Id == id))
            {
                return _sabores
                    .Where(b => b.Id == id)
                    .First();
            }
            throw new Exception("Não encontrado");
        }

        public List<Sabor> ObterTodos()
        {
            return _sabores;
        }
    }
}