namespace PizzariaCSharp.Controller.Interfaces
{
    /// <summary>
    /// Interface genérica para os CRUDs de controller.
    /// </summary>
    /// <typeparam name="T">Modelo que será controlado.</typeparam>
    public interface ICrudController<T>
    {
        /// <summary>
        /// Adiciona um registro ao banco de dados.
        /// </summary>
        /// <param name="modelo">Modelo a ser adicionado</param>
        /// <returns>Retorna o registro adicionado</returns>
        public T Adicionar(T modelo);

        /// <summary>
        /// Obtem todos os registros cadastrados no banco de dados.
        /// </summary>
        /// <returns>Retorna uma lista de todos os registros da entidade no banco de dados.</returns>
        public List<T> ObterTodos();

        /// <summary>
        /// Busca um registro pelo seu id.
        /// </summary>
        /// <param name="id">Id a ser encontrado.</param>
        /// <returns>Retorna o registro com o id dado.</returns>
        public T ObterPorId(int id);

        /// <summary>
        /// Atualiza um registro no banco de dados.
        /// </summary>
        /// <param name="id">Id do registro a ser atualizado.</param>
        /// <param name="modelo">Novos dados do registro.</param>
        /// <returns>Retorna o registro atualizado.</returns>
        public T Atualizar(int id, T modelo);

        /// <summary>
        /// Deleta um registro pelo seu id
        /// </summary>
        /// <param name="id">Id do registro a ser deletado.</param>
        public void Deletar(int id);
    }
}