// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enum");

Console.WriteLine(Categorias.Moda);
int dia = (int)DiasDaSemana.Quarta;
Console.WriteLine(DiasDaSemana.Quarta);
Console.WriteLine($"Dias da semana Quarta vale:{dia}");
enum DiasDaSemana : byte
{
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado,
    Domingo
}

enum Categorias
{
    Moda,
    Automotivo,
    Artes,
    Bebidas,
    Livros,
    Brinquedos
}
enum CodigoErro
{
    Nenhum = 0,
    Desconhecido = 1,
    ConexaoFalhou = 100,
    DadosInvalidos = 200
}