using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
    public abstract class ContaBancaria
    {
        #region Atributos
        public Titular Titular { get; set; }
        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }
        protected readonly double VALOR_MINIMO = 10.0;
        protected List<Movimentacao> Movimentacoes { get; set; }
        #endregion

        #region Construtores
        public ContaBancaria(Titular titular, double saldoAbertura)
        {
            Titular = titular;
            Saldo = saldoAbertura;
            DataAbertura = DateTime.Now;
            Movimentacoes = new List<Movimentacao>()
            {
                new Movimentacao(TipoMovimentacao.AberturaConta, saldoAbertura)
            };
        }

        public ContaBancaria(Titular titular)
        {
            Titular = titular;
            Saldo = 0;
            DataAbertura = DateTime.Now;
            Movimentacoes = new List<Movimentacao>()
            {
                new Movimentacao(TipoMovimentacao.AberturaConta, Saldo)
            };
        }

        #endregion

        #region Métodos
        public void Depositar(double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("Valor mínimo de R$" + VALOR_MINIMO + " para depósito.");
            }

            Saldo += valor;
            Movimentacoes.Add(new Movimentacao(TipoMovimentacao.Deposito, valor));
        }

        public double Sacar(double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("Valor mínimo de R$" + VALOR_MINIMO + " para saque.");
            }
            else if (valor > Saldo)
            {
                throw new Exception("Saldo insuficiente. Saldo atual: R$" + Saldo);
            }

            Saldo -= valor;
            Movimentacoes.Add(new Movimentacao(TipoMovimentacao.Saque, valor));
            return valor;
        }

        public void Transferir(ContaBancaria contaDestino, double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("Valor mínimo de R$" + VALOR_MINIMO + " para transferência.");
            }
            else if (valor > Saldo)
            {
                throw new Exception("Saldo insuficiente. Saldo atual: R$" + Saldo);
            }

            Saldo -= valor;
            Movimentacoes.Add(new Movimentacao(TipoMovimentacao.Transferencia, valor));
            contaDestino.Depositar(valor);
        }

        public virtual void ImprimirExtrato()
        {
            System.Console.WriteLine("Imprime extrato.");
        }

        #endregion

    }
}