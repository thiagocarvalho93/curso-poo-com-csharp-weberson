namespace BancoCSharp.Models
{
    public class ContaCorrente : ContaBancaria
    {
        #region Construtores
        public ContaCorrente(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }

        public ContaCorrente(Titular titular) : base(titular)
        {
        }
        #endregion

        #region Métodos
        public override void ImprimirExtrato()
        {
            System.Console.WriteLine("**********************");
            System.Console.WriteLine("Extrato conta corrente");
            System.Console.WriteLine("**********************");

            System.Console.WriteLine("Gerado em:" + DateTime.Now);

            foreach (var item in Movimentacoes)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("**********************");
            System.Console.WriteLine("FIM DO EXTRATO");
            System.Console.WriteLine("**********************");
            System.Console.WriteLine("Saldo atual:" + Saldo);

        }
        #endregion
    }
}