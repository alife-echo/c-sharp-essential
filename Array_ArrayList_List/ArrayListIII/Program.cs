// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("ArrayListIII");


var lista = new ArrayList() {"Ana",5,true," ",null,1.1,"Zé",3,9,0};

lista.Remove(null);
lista.RemoveAt(4);
lista.RemoveRange(0,2);


Console.ReadKey();