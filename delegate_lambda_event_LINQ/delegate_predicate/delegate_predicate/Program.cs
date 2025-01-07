

Console.WriteLine("Digite um número : ");
var numero = Convert.ToInt32(Console.ReadLine());

Predicate<int> delegatePar = (n) => n%2 == 0;

var res = delegatePar(numero) ? $"O numero {numero} é PAR" : $"O numero é {numero} é IMPAR";

Console.WriteLine(res);