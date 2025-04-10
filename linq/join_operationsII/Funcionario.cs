using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join_operationsII;

    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string FuncionarioNome { get; set; } = null!;
        public string FuncionarioCargo { get; set; } = null!;

        public int? SetorId { get; set; }


    }

