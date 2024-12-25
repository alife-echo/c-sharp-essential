
namespace pooExercicios;
// Exercicio 1
public class Carro : IVeiculo
{
    private int qtd_gasolina;
    public int QtdGasolinaInicial {  get; set; }
    public int QtdGasolina { 
        get 
        {
            return qtd_gasolina;
        } 
        set 
        {
            qtd_gasolina = value; 
        } 
    }
    public Carro(int QtdGasolinaInicial)
    {
        this.QtdGasolinaInicial = QtdGasolinaInicial;
    }
    public void Dirigir()
    {
        Console.WriteLine
        (
            QtdGasolinaInicial > 0 ? 
            "Dirigindo o Carro" :
            "Sem gasolina"
        );
    }
    public bool Abastecer(int qtdGasolina)   
    {
        if (qtdGasolina > 0)
        {
             QtdGasolina = qtdGasolina;
             QtdGasolinaInicial = qtdGasolina;
             return true;
        }
        return false;
    }
}
