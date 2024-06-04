// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("ListAndArrayList");


ArrayList lista = new ArrayList();  

lista.Add(3);
lista.Add(105);

var elemento = lista[0];
int el = lista is not null ? (int)lista[1] : 0;


List<int> lista2 = new List<int>();
lista2.Add(5);
lista2.Add(4);

var elemento2 = lista2[0];
var el2 = lista2[1];    