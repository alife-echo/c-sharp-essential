
namespace exerciseLINQ;
public class Pedido
{
    public int Id { get; set; }
    public string? Nome { get; set; } = string.Empty;
    public int IdCliente { get; set; }

    public static List<Pedido> GetPedidos()
    {
        var pedidos = new List<Pedido>() 
        {
            new Pedido { Id = 1, Nome = "Pedido A1", IdCliente = 1 },
            new Pedido { Id = 2, Nome = "Pedido A2", IdCliente = 1 },
            new Pedido { Id = 3, Nome = "Pedido B1", IdCliente = 2 },
            new Pedido { Id = 4, Nome = "Pedido C1", IdCliente = 3 },
            new Pedido { Id = 5, Nome = "Pedido C2", IdCliente = 3 },
            new Pedido { Id = 6, Nome = "Pedido C3", IdCliente = 3 },
            new Pedido { Id = 7, Nome = "Pedido E1", IdCliente = 5 },
            new Pedido { Id = 8, Nome = "Pedido F1", IdCliente = 6 },
            new Pedido { Id = 9, Nome = "Pedido F2", IdCliente = 6 }
        };
        return pedidos;
    }
}

