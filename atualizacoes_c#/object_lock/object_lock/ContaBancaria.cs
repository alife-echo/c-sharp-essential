using System.Threading;
namespace object_lock;

public class ContaBancaria
{
    private readonly Lock _lock = new();
}