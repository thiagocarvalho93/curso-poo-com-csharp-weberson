
namespace PizzariaCSharp.Repository.Interfaces
{
    /// <summary>
    /// Interface do repositório genérico baseado na construção do modelo.
    /// </summary>
    /// <typeparam name="T">Modelo, entidade a qual será persistida</typeparam>
    public interface ICrudRepository<T>
    {
        /// <summary>
        /// Método que adiciona um modelo ao banco de dados.
        /// </summary>
        /// <param name="modelo">Modelo que será adicionado</param>
        /// <returns>Retorna o modelo após adição no banco de dados</returns>
        public T Adicionar(T modelo);

        /// <summary>
        /// Método que retorna uma lista com todos os modelos encontrados no banco de dados.
        /// </summary>
        /// <returns>Lista com todos os modelos</returns>
        public List<T> ObterTodos();

        /// <summary>
        /// Método para encontrar um modelo pelo seu id.
        /// </summary>
        /// <param name="id">Id do modelo a ser procurado</param>
        /// <returns>Retorna o modelo encontrado pelo id entrado.</returns>
        public T ObterPorId(int id);

        /// <summary>
        /// Método para atualizar um modelo no banco de dados.
        /// </summary>
        /// <param name="modelo">Modelo a ser atualizado</param>
        /// <returns>Retorna o modelo após a atualização</returns>
        public T Atualizar(T modelo);

        /// <summary>
        /// Deleta o modelo pelo seu id.
        /// </summary>
        /// <param name="id">Id do modelo a ser deletado.</param>
        public void Deletar(int id);
    }
}