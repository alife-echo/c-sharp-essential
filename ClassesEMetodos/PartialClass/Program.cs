// See https://aka.ms/new-console-template for more information
using _22PartialClass;

Console.WriteLine("Partil Class");

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

var idade = minhaPartialClass.CalculaIdade(new DateTime(2001, 10, 26));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");


var data1 = DateTime.Now;
var data2 = new DateTime(2001, 10, 26);

var diferenca = minhaPartialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos ");

Console.WriteLine($"DataAtual:{data1}");

Console.ReadKey();