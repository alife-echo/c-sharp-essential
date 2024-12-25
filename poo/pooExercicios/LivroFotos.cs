
namespace pooExercicios;
//Exercicio 2
public class LivroFotos
{
    private int _numPaginas;

    public int NumPaginas
    {
        get
        {
            return _numPaginas;
        }
        set
        {
            _numPaginas = value;
        }
    }
    public int GetNumeroPaginas()
    {
        return NumPaginas;
    }
    public LivroFotos()
    {
        this.NumPaginas = 16;
    }
    public LivroFotos(int numPaginas)
    {
        this.NumPaginas = numPaginas;    
    }

    public void GetExibirNumeroPaginas ()
    {
        Console.WriteLine($"O número de paginas é :{GetNumeroPaginas()}");
    }


}

