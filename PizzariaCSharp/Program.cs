// See https://aka.ms/new-console-template for more information
using PizzariaCSharp.Controller;
using PizzariaCSharp.Enums;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

System.Console.WriteLine("Simulando API");

# region Controllers
// Instanciando os controllers
var bebidaController = new BebidaController(new BebidaRepository());
var saborController = new SaborController(new SaborRepository());
var pizzaController = new PizzaController(new PizzaRepository());
var clienteController = new ClienteController(new ClienteRepository());
var pedidoController = new PedidoController(new PedidoRepository());
#endregion

# region Cadastros
// Cadastrar 2 bebidas
var bebida1 = bebidaController.Adicionar(new Bebida
{
    Descricao = "Coca 2l",
    Valor = 10.0
});
var bebida2 = bebidaController.Adicionar(new Bebida
{
    Descricao = "H20 Limoneto",
    Valor = 10.0
});

// Cadastrar 4 sabores
var sabor1 = saborController.Adicionar(new Sabor
{
    Descricao = "4 queijos",
    Observacao = ""
});
var sabor2 = saborController.Adicionar(new Sabor
{
    Descricao = "Portuguesa",
    Observacao = ""
});
var sabor3 = saborController.Adicionar(new Sabor
{
    Descricao = "Calabresa",
    Observacao = ""
});
var sabor4 = saborController.Adicionar(new Sabor
{
    Descricao = "Frango com catupiry",
    Observacao = ""
});

// Cadastrar 2 clientes
var cliente1 = clienteController.Adicionar(new Cliente
{
    Nome = "Renato Silveira",
    Telefone = "22998272839",
});
var cliente2 = clienteController.Adicionar(new Cliente
{
    Nome = "Jose Francisco",
    Telefone = "21998762739",
});

# endregion

# region Pedido
// Cadastrar Pedidos
var pedido1 = new Pedido(cliente1);

pedido1
    .AdicionarBebida(bebida1)
    .AdicionarBebida(bebida2)
    .AdicionarPizza(new Pizza(ETipoPizza.GIGANTE, ETipoBorda.COM_CATUPIRY, new List<Sabor> { sabor1 }, 50.00))
    .AdicionarPizza(new Pizza(ETipoPizza.GRANDE, ETipoBorda.COM_CHEDDAR, new List<Sabor> { sabor1, sabor2 }, 35.00))
    .AdicionarPizza(new Pizza(ETipoPizza.SUPER_GIGANTE, ETipoBorda.SEM_BORDA, new List<Sabor> { sabor3, sabor4 }, 60.00))
    .ObterValorTotal();

pedido1.Finalizar();
pedidoController.Adicionar(pedido1);

#endregion