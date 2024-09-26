
using operador_is_e_as_fix;

Circulo circulo = new Circulo(10, 20);
Forma forma = circulo;

if(forma is Circulo)
{
    Console.WriteLine("Converteu Forma para Circulo");
    (forma as Circulo)?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}

/*
 * Object carroObj = new Carro();
var x = carroObj as string;

Circulo circulo = new Circulo(10,20);
Forma forma = circulo;

Circulo c = forma as Circulo;

if(c != null)
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Operação downcasting invalida");
}

if(x != null)
{
    Console.WriteLine("Converteu obj para string");
}
else
{
    Console.WriteLine("Não foi possivel converter");
}

Console.ReadKey();




class Carro
{

}
*/