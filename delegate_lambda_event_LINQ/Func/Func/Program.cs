
Console.WriteLine("Digite um numero");

var numero = Convert.ToDouble(Console.ReadLine());

Func<double,double> raizQuadrada = x => Math.Sqrt(x);

double resultado = raizQuadrada(numero);

Console.WriteLine($"A raiz quadrada do numero : {numero} é : {resultado}");

Console.ReadKey();

