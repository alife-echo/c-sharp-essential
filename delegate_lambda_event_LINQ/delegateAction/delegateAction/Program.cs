
Console.WriteLine("Informe um número inteiro.");
var numero = Convert.ToInt32(Console.ReadLine());


Action<int> res = (x) => Console.WriteLine(x * 2);


res(numero);

Console.ReadKey();

