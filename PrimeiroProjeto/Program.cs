using PrimeiroProjeto;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var meuCarro = new Carro
{
    Modelo = "Fusion",
    Cor = "Preto",
    Ano = 2022
};

Console.WriteLine(meuCarro.Modelo);
Console.WriteLine(meuCarro.Cor);
Console.WriteLine(meuCarro.Ano);

meuCarro.LigarCarro();
meuCarro.Buzinar();

var pessoa1 = new Pessoa(21);

pessoa1.Nome = "José";
pessoa1.Sobrenome = " da Silva";

