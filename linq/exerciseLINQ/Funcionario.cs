

namespace exerciseLINQ;
public class Funcionario
{

    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Salario { get; set; }
    public string Cargo { get; set; } = string.Empty;
    public string Departamento { get; set; } = string.Empty;

    public static List<Funcionario> GetFuncionarios()
    {
        var funcionarios = new List<Funcionario>()
        {
            new Funcionario { Id = 1, Nome = "Amanda Costa", Cargo = "Analista", Departamento = "TI", Salario = 4500.00m },
            new Funcionario { Id = 2, Nome = "Bruno Silva", Cargo = "Desenvolvedor", Departamento = "TI", Salario = 5800.00m },
            new Funcionario { Id = 3, Nome = "Carla Mendes", Cargo = "Gerente", Departamento = "RH", Salario = 7200.00m },
            new Funcionario { Id = 4, Nome = "Diego Martins", Cargo = "Assistente", Departamento = "Financeiro", Salario = 3200.00m },
            new Funcionario { Id = 5, Nome = "Eduarda Lima", Cargo = "Analista", Departamento = "Financeiro", Salario = 4000.00m },
            new Funcionario { Id = 6, Nome = "Felipe Rocha", Cargo = "Coordenador", Departamento = "TI", Salario = 6700.00m },
            new Funcionario { Id = 7, Nome = "Gabriela Torres", Cargo = "Estagiária", Departamento = "RH", Salario = 1500.00m },
            new Funcionario { Id = 8, Nome = "Henrique Souza", Cargo = "Desenvolvedor", Departamento = "TI", Salario = 6000.00m },
            new Funcionario { Id = 9, Nome = "Isabela Duarte", Cargo = "Analista", Departamento = "Marketing", Salario = 4300.00m },
            new Funcionario { Id = 10, Nome = "João Pedro", Cargo = "Diretor", Departamento = "Executivo", Salario = 12000.00m }
        };
        return funcionarios;
    }
    
}

