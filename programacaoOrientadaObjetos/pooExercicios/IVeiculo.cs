using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooExercicios;
// Exercicio 1
public interface IVeiculo
{
    public int QtdGasolina {  get; set; }
    void Dirigir();

    bool Abastecer(int qtdGasolina);
   
    
        
    
    
}

