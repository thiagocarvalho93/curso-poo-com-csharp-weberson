using BancoCSharp.Enums;
using BancoCSharp.Models;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("********************************");
Console.WriteLine("Banco C#");
Console.WriteLine("********************************");

var endereco1 = new Endereco
{
    Cep = "21345-200",
    Rua = "Rua x",
    Numero = 123
};

var titular1 = new Titular("José da Silva", "12345678901", "2199997788", endereco1);
var titular2 = new Titular("Maria da Silva", "12345678911", "2199997799", endereco1);


var conta1 = new ContaPoupanca(titular1, 100.0);
var conta2 = new ContaCorrente(titular2);
var conta3 = new ContaInvestimento(titular2);

conta1.Depositar(100);
conta2.Depositar(500);
conta2.Sacar(10);
conta2.Transferir(conta3, 200);

conta1.ImprimirExtrato();
conta2.ImprimirExtrato();
conta3.ImprimirExtrato();
