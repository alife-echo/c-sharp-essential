// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Nullable Types ##");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

// Simplificando

int? a = null;
double? w  = null;
bool? c = null;


//?? -> coalescência nula
//?? ->usar para atribuir um valor de tipo anulavel a um não anulavel
int ? x = null;
int y = x ?? 0;
Console.WriteLine(y);

//exemplo pratico
/* minha solução
int? h = 4;
int j = 3;
int z = (h * j) ?? 0; 
Console.WriteLine(z);
 */
// solução aula
int? h = 4;
int? j = 3;
int? z = h * j;
Console.WriteLine(z);



// Propriedades somete Leitura: HasValue e Value

int? l = 100;
if (l.HasValue)
{
    Console.WriteLine($"l = {l.Value}");
}
else
{
    Console.WriteLine("l não possui valor é null");
}


Console.WriteLine(a);
Console.WriteLine(w);
Console.WriteLine(c);

Console.ReadKey();