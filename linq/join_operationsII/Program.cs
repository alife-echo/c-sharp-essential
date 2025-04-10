using join_operationsII;

var funcionarios = new List<Funcionario>
{
    new Funcionario {FuncionarioNome = "Marisa monte",FuncionarioCargo = "Gerente",SetorId = 1},
    new Funcionario {FuncionarioNome = "Janice Ribeiro",FuncionarioCargo = "Administrativo",SetorId = 1},
    new Funcionario {FuncionarioNome = "Bob",FuncionarioCargo = "Administrativo",SetorId = 1},
    new Funcionario {FuncionarioNome = "Pedro Toledo",FuncionarioCargo = "Gerente",SetorId = 2},
    new Funcionario {FuncionarioNome = "Andre Sanches",FuncionarioCargo = "Contador",SetorId = 2},
    new Funcionario {FuncionarioNome = "Hilda Hinst",FuncionarioCargo = "Diretora"},
    new Funcionario {FuncionarioNome = "Ana Maria Lima",FuncionarioCargo = "Gerente",SetorId = 3},
    new Funcionario {FuncionarioNome = "Carlos Ribeiro",FuncionarioCargo = "Designer",SetorId = 3},
    new Funcionario {FuncionarioNome = "Jaime Lacuste",FuncionarioCargo = "CEO"},
};

var setores = new List<Setor>
{
    new Setor {SetorName = "Contabilidade",SetorId = 2 },
    new Setor {SetorName = "Marketing",SetorId = 3 },
    new Setor {SetorName = "Recursos Humanos",SetorId = 1 },
    new Setor {SetorName = "Tecnologia",SetorId = 4 }
};
var leftJoin = funcionarios
    .GroupJoin(
        setores, // Segunda fonte de dados
        func => func.SetorId, // Chave comum na primeira fonte (funcionarios)
        setor => setor.SetorId, // Chave comum na segunda fonte (setores)
        (func, setorGroup) => new {
            Funcionario = func,
            Setor = setorGroup.DefaultIfEmpty() // Caso não haja correspondência, retorna null (LEFT JOIN)
        }
    )
    .SelectMany(
        x => x.Setor, // Expande a coleção de setores para cada funcionário
        (funcSetor, setor) => new // Cria um novo formato de saída com as informações desejadas
        {
            FuncionarioNome = funcSetor.Funcionario.FuncionarioNome,
            FuncionarioCargo = funcSetor.Funcionario.FuncionarioCargo,
            SetorNome = setor?.SetorName ?? "Sem Setor" // Se não houver setor correspondente, exibe "Sem Setor"
        }
    );


var rightJoin = setores
    .GroupJoin(
        funcionarios, // Junta os setores com os funcionários correspondentes
        setor => setor.SetorId, // Chave comum na primeira fonte (setores)
        func => func.SetorId, // Chave comum na segunda fonte (funcionarios)
        (setor, funcGroup) => new {
            Funcionario = funcGroup.DefaultIfEmpty(), // Se não houver funcionários no setor, retorna null
            Setor = setor // Mantém o setor sempre presente no resultado (RIGHT JOIN)
        }
    )
    .SelectMany(
        x => x.Funcionario, // Expande a coleção de funcionários para que cada setor tenha múltiplas linhas (uma por funcionário)
        (setorFunc, func) => new // Cria um novo formato de saída com os dados desejados
        {
            FuncionarioNome = func?.FuncionarioNome ?? "Sem Funcionário", // Se não houver funcionário, exibe "Sem Funcionário"
            FuncionarioCargo = func?.FuncionarioCargo ?? "Sem Cargo", // Se não houver funcionário, exibe "Sem Cargo"
            SetorNome = setorFunc.Setor.SetorName // O nome do setor sempre será exibido
        }
    );

var unionJoin = leftJoin.Union(rightJoin);

// f => setores, (func, setor) => para cada elemento de funcionarios 'f' ele combina  com todos os setores em "setores"
// depois passamos os argumentos func e setor para montar um objeto anonimo com os dados que queremos recuperar
var crossJoin = funcionarios.SelectMany(f => setores, (func, setor) => 
                                        new {
                                            Nome = func.FuncionarioNome,
                                            Cargo = func.FuncionarioCargo,
                                            Setor = setor.SetorName
                                        });
var grupJoin = setores.GroupJoin(
           funcionarios,
           s => s.SetorId,
           f => f.SetorId,
           (s, funcionariosGrupo) => new
           {
               Funcionarios = funcionariosGrupo,
               NomeSetor = s.SetorName
           }
    ).ToList();




Console.WriteLine("Union Join");
foreach (var item in unionJoin)
{
    Console.WriteLine($"Nome: {item.FuncionarioNome}, Cargo: {item.FuncionarioCargo}, Setor: {item.SetorNome}");
}

Console.WriteLine();
Console.WriteLine("Cross Join");
foreach (var value in crossJoin)
{
    Console.WriteLine($"Nome: {value.Nome}, Cargo: {value.Cargo}, Setor: {value.Setor}");
}

Console.WriteLine();
Console.WriteLine("GroupJoin");
foreach (var value in grupJoin)
{
    Console.WriteLine($"Nome: {value.NomeSetor}");
    foreach(var valueF in value.Funcionarios)
    {
       Console.WriteLine($"Cargo: {valueF.FuncionarioNome}");
    }
}


