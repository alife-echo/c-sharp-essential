
namespace exerciseLINQ;
public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; } = string.Empty;

    public static List<Cliente> GetClientes()
    {
        var clientes = new List<Cliente>() 
        {
            new Cliente { Id = 1, Nome = "Amanda Rocha" },
            new Cliente { Id = 2, Nome = "Bruno Mendes" },
            new Cliente { Id = 3, Nome = "Carolina Dias" },
            new Cliente { Id = 4, Nome = "Daniel Souza" },
            new Cliente { Id = 5, Nome = "Eduardo Lima" },
            new Cliente { Id = 6, Nome = "Fernanda Alves" }
        };

        return clientes;
    }
}

