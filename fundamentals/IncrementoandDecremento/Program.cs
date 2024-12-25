// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores incrementais e decrementais\n");

//Objetivo = Aumentar ou Diminuir exatamente em uma unidade o valor de uma variável

//Operador de incremento : ++ 

//Operador de Decremento : --


// Operador        Exemplo            Significado
//   ++           x++; ou ++x;         x = x + 1;
//   --           x--; ou --x;         x = x - 1

// Operador de Incremento : ++
// pré-incremento : ++x
// pós-incremnto  : x++

// Operador de Decremento : --
// pré-decremento : --x
// pós-decremnto  : x--


Console.WriteLine("Pós-incremento\n");
// primeiro resolve a expressão depois incrementa
int x = 0;
int resultado1 = x++ + 10;
// x = 1 depois da resolução da expressão
Console.WriteLine($"resultado ${resultado1}\n");


Console.WriteLine("Pré-incremento\n");
//primeiro incrementa depois resolve a expressão
int x2 = 0;
// x = 1 antes da resolução da expressão
int resultado2 = ++x2 + 10;
Console.WriteLine($"resultado ${resultado2}\n");

// mesma logica para o decremento --