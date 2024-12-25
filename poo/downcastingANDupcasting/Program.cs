using downcastingANDupcasting;

Circulo circulo = new Circulo(20,20);
Forma f = circulo;  //upcasting

Circulo c = (Circulo)f; // DownCasting

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);


Console.ReadKey();