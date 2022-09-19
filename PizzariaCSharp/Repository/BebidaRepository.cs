using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class BebidaRepository : ICrudRepository<Bebida>
    {
        private List<Bebida> _bebidas;
        private int _ultimoId = 0;

        public BebidaRepository()
        {
            _bebidas = new List<Bebida>();
        }

        public Bebida Adicionar(Bebida bebida)
        {
            _ultimoId++;
            bebida.Id = _ultimoId;

            _bebidas.Add(bebida);

            return bebida;
        }

        public List<Bebida> ObterTodos()
        {
            return _bebidas;
        }

        public Bebida ObterPorId(int id)
        {
            if (_bebidas.Any(b => b.Id == id))
            {
                return _bebidas
                    .Where(b => b.Id == id)
                    .First();
            }
            throw new Exception("Não encontrado");
        }

        public Bebida Atualizar(Bebida bebida)
        {
            var bebidaEncontrada = ObterPorId(bebida.Id);

            _bebidas.Remove(bebidaEncontrada);
            _bebidas.Add(bebida);

            return bebida;
        }

        public void Deletar(int id)
        {
            var bebida = ObterPorId(id);

            _bebidas.Remove(bebida);
        }
    }
}