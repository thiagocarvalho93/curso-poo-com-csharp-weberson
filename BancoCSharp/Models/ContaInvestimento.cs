namespace BancoCSharp.Models
{
    public class ContaInvestimento : ContaBancaria
    {
        #region Atributos
        public double ValorInvestido { get; private set; }
        
        #endregion

        #region Construtores
        public ContaInvestimento(Titular titular) : base(titular)
        {
        }

        public ContaInvestimento(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }
        #endregion

        #region Métodos
        public override void ImprimirExtrato()
        {
            System.Console.WriteLine("**************************");
            System.Console.WriteLine("Extrato conta investimento");
            System.Console.WriteLine("**************************");

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