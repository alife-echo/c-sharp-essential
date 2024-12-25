
var numeros = new HashSet<int>
{
    1,2,3,4
};

var frutas = new HashSet<string> {"uva","maça","abacaxi"};




HashSet<int> pares= new HashSet<int>();

for (int i = 0; i < 6; i++)
{
    pares.Add(i * 2);
}


var numerosList = new List<int>(){1,2,3,4};
HashSet<int> conjunto = new HashSet<int>(numerosList);

var frutasList = new List<string>(){"uva","banana","pera"};
HashSet<string> minhasFrutas = new HashSet<string>(frutasList);

var impares = new int[] {1,3,5,7,9,11,13};
HashSet<int> meuhashSet = new HashSet<int>(impares);



Console.WriteLine(conjunto.GetHashCode());
conjunto.ExceptWith(meuhashSet);






