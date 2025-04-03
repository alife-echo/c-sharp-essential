using join_operations;


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
    new Setor {SetorName = "Recursos Humanos",SetorId = 1 }
};

// no codigo abaixo definimos duasfonte de dados, assim como seus atributos em comum para o innerjoin(inner key selector e outer key selector)
// depois da interseção,criamos um tipo anonimo para selecionar os dados que queremos obter dessa consula inner join
var innerJoin = funcionarios.Join( // outer data source
    setores, // inner data source
    funcionarios => funcionarios.SetorId, // inner key selector
    setores => setores.SetorId, // outer key selector
    (funcionarios, setores) => new // projetando os dados para um tipo anonimo, um novo formato selecionando os dados que quero
    {
        NomeFuncionario = funcionarios.FuncionarioNome,
        NomeSetor = setores.SetorName,
        CargoFuncionario = funcionarios.FuncionarioCargo
    }).ToList();

Console.WriteLine("Funcionario \t\tCargo\t\tSetor");

foreach(var funcionario in innerJoin)
{
    Console.WriteLine($"{funcionario.NomeFuncionario}" + 
         $"\t\t{funcionario.CargoFuncionario}" +    
         $"\t\t{funcionario.NomeSetor}"    
        );
}
Console.WriteLine();
Console.WriteLine();

//DefaultEmpty caso uma coleção estiver vazia, retornar um valor padrão, nesse caso é null
// Realiza um LEFT JOIN entre funcionarios e setores
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


foreach (var item in leftJoin)
{
    Console.WriteLine($"Nome: {item.FuncionarioNome}, Cargo: {item.FuncionarioCargo}, Setor: {item.SetorNome}");
}
/*
 
Antes do SelectMany: Setor ainda é uma coleção, e cada funcionário pode ter um ou mais elementos dentro dessa coleção.

Depois do SelectMany: A coleção foi achatada, e cada funcionário aparece em uma linha única com seu setor correspondente.
 
 */