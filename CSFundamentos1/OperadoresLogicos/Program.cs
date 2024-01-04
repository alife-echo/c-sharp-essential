// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores logicos");
/*
 
&& -> and
|| -> or
!  -> not
 
 */

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool resultado;
Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 =  {c2}\n");

// operador AND -> &&
resultado = c1 && c2;
Console.WriteLine("Operadodor AND(&&) : "+resultado);
resultado = c1 || c2;
Console.WriteLine("Operadodor OR(||) : "+resultado);
resultado = !(c1||c2);
Console.WriteLine("Operadodor NOT(!) : "+resultado);



Console.ReadKey();