namespace PrimeiroProjeto
{
    public class Pessoa
    {
        #region Atributos
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        private int Idade { get; set; }
        public string? NomeCompleto => Nome + Sobrenome;
        #endregion

        #region Construtores
        public Pessoa(int idade)
        {
            Idade = idade;
        }
        #endregion

        #region Métodos


        #endregion

    }
}