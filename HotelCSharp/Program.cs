using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;
using HotelCSharp.Models;

System.Console.WriteLine("**************************************");
System.Console.WriteLine("**************************************");
System.Console.WriteLine("HOTEL C SHARP");
System.Console.WriteLine("**************************************");
System.Console.WriteLine("**************************************");

ICamareira camareira1 = new Camareira("Maria da Silva", "12345678901", "21 9999999");
ICamareira camareira2 = new Camareira("Fulana da Silva", "12345678902", "21 9999993");

IRecepcionista recepcionista1 = new Recepcionista("Mariana Gonçalves", "12312312312", "22 91238982");
IRecepcionista recepcionista2 = new Recepcionista("Joana Soares", "1231212345", "22 91238942");

IGerente gerente1 = new Gerente("Fulano de Tal", "12334534534", "22 987898789");
IGerente gerente2 = new Gerente("Ciclano de Tal", "12334534532", "22 987898782");

Hotel hotel = new Hotel("Hotel CSharp", new Endereco()
{
    CEP = "27888888",
    Rua = "Rua x",
    Numero = 123,
    Complemento = "casa 2",
    Bairro = "Lugar nenhum",
    Cidade = "Qualquer lugar"
});

hotel.contratarCamareira(camareira1);
hotel.contratarCamareira(camareira2);

foreach (var camareira in hotel.Camareiras)
{
    camareira.SeApresentar();
    camareira.ArrumarCama();
    camareira.LimparQuarto();
}

hotel.contratarRecepcionista(recepcionista1);
hotel.contratarRecepcionista(recepcionista2);

foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.SeApresentar();
    recepcionista.AtenderTelefone();
    recepcionista.FalarIngles();
}

// RH Terceirizado
IRHTerceirizado rh = new RH("RH Csharp", hotel);

// Contratar uma camareira
var camareira3 = new Camareira
{
    Nome = "Eugênia Ferraz"
};
rh.contratarCamareira(camareira3);

// Contratar uma recepcionista
var recepcionista3 = new Recepcionista("Sophia Bastos", "1231212342", "22 91238912");
rh.contratarRecepcionista(recepcionista3);

// Promova uma camareira
var camareiraPromovida = new Camareira
{
    Nome = "Eugênia Lima",
};

try
{
    rh.promoverParaGerente(camareiraPromovida);
}
catch (DocumentosInvalidosException ex)
{
    // cai aqui se a Documentação é inválida
    System.Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    // cai aqui se der ruim no sistema
    System.Console.WriteLine(ex.Message);
}

// Promova uma recepcionista
var recepcionistaPromovida = new Recepcionista
{
    Nome = "Amanda Vasconcelos",
    CPF = "12312312332",
};

try
{
    rh.promoverParaGerente(recepcionistaPromovida);
}
catch (DocumentosInvalidosException ex)
{
    // cai aqui se a Documentação é inválida
    System.Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    // cai aqui se der ruim no sistema
    System.Console.WriteLine(ex.Message);
}

System.Console.WriteLine();