
namespace pooExercicios;
public abstract class Database
{
    public virtual void Conectar()
    {
        Console.WriteLine("Conectando ao banco de dados ....");
    }
    public abstract void Configurar();
}

