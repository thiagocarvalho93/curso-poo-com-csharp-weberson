using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
    public class Movimentacao
    {
        #region Atributos
        private DateTime DataHoraMovimentacao { get; set; }
        private TipoMovimentacao TipoMovimentacao { get; set; }
        private double Valor { get; set; }
        #endregion

        #region Construtores
        public Movimentacao(TipoMovimentacao tipoMovimentacao, double valor)
        {
            DataHoraMovimentacao = DateTime.Now;
            TipoMovimentacao = tipoMovimentacao;
            Valor = valor;
        }

        public override string ToString()
        {
            var valor = (this.TipoMovimentacao == TipoMovimentacao.Saque
            || this.TipoMovimentacao == TipoMovimentacao.Transferencia)
             ? $"-R${Valor}" : $"R${Valor}";
            return $"{DataHoraMovimentacao}hs | {TipoMovimentacao} | {valor}";
        }

        #endregion


    }
}