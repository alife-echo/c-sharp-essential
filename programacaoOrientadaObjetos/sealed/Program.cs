// See https://aka.ms/new-console-template for more information




Console.ReadKey();


class ClassBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe1 : ClassBase
{
   sealed protected override void Metodo1()
    {
        Console.WriteLine("Classe1.Metodo1");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo1");
    }
}

class Classe2 : Classe1
{
    sealed protected override void Metodo1()
    { }
}