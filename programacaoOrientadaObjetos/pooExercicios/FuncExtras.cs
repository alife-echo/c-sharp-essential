using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooExercicios;
public interface FuncionalidadesContaCorrente
{

    void AgendarPagamento(float valor, DateTime data,int beneficitario);
    void RealizarInvestimento(float valor, string tipoInvestimento);
    void BloquarCartaoTemporariamente();
}

