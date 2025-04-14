using page_skip_take;

int RegistroPorPagina = 4;

int NumeroPagina = 0;


do
{
    Console.WriteLine("\n Informe o número da pagina entre 1 e 4");
    
    if(int.TryParse((Console.ReadLine()), out NumeroPagina))
    {
        if(NumeroPagina > 0 && NumeroPagina < 5)
        {
            var alunos = Aluno.GetAlunos().AsQueryable().GetPaged(NumeroPagina, RegistroPorPagina).Results; // acessamos os resultados pela propriedade e Results

            Console.WriteLine("\nPag : " + NumeroPagina);

            foreach(var aluno in alunos)
                Console.WriteLine($"Id:{aluno.Id},Nome:{aluno.Nome},Curso:{aluno.Curso}");
        }
        else
            Console.WriteLine("Informe um número da pagina valido");
    }
    else
        Console.WriteLine("Informe um número da pagina valido");
} while (true);