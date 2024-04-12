// See https://aka.ms/new-console-template for more information

using _18Enumeration;


Console.WriteLine("## Enum ## \n");

foreach (var category in Enum.GetValues(typeof(Categorias))){
    Console.WriteLine($"Nome:{category},Valor:{(int)category}");
}
Console.WriteLine("\nSelecione a Categoria teclando o seu valor");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;
Console.WriteLine($"\n Voce Selecionou a categoria : {nomeMembroEnum.ToString()}");

Console.WriteLine(DiasDaSemana.Domingo);
Console.WriteLine(DiasDaSemana.Terça);

int dia1 = (int)DiasDaSemana.Domingo;
int dia2 = (int)DiasDaSemana.Terça;

Console.WriteLine($"\n {DiasDaSemana.Domingo} vale : {dia1}");
Console.WriteLine($"\n {DiasDaSemana.Terça} vale : {dia2}");
Console.ReadKey();
