/*
 * 1)
 *    a = V, b = V, c = V , d = V , e = V, f = F , g = F , h = V
 *
 *
 *
 *
 * 2)
 * OperacaoMatematica op1 = new OperacaoMatematica(Soma);
   Console.WriteLine($"Resultado:{op1(10,20)}");
 * static int Soma(int x, int y)
   {
       return x + y;
   }

    public delegate int OperacaoMatematica(int x,int y);
 *
 *
 *
 *
 *
 *3)
 *  var boasVindas = new MensagemBoasVindas(BoasVindasPt);
    boasVindas += BoasVindasEng;
    boasVindas();
 *
 *
 * static void BoasVindasPt()
   {
       Console.WriteLine("Bem-Vindo!");
   }

   static void BoasVindasEng()
   {
       Console.WriteLine("Welcome!");
   }

   public delegate void MensagemBoasVindas();
 *
 *
 *
 *
 * 4)
 *  a = V, b = V, c = V, d = V, e = V, f = V, g = V, h = V
 *
 *
 *
 *
 * int[] numeros = { 1, 2, 3, 4, 5 };

   Action<int> exibirNumero = num => Console.WriteLine(num);
   Array.ForEach(numeros,exibirNumero);


   Predicate<int> ehPar = num => num % 2 == 0;
   bool todosPares = Array.TrueForAll(numeros,ehPar);

   Func<int, int, int> somar = (a, b) => a + b;
   int resultado = somar(10, 10);

   Console.WriteLine(todosPares);
   Console.WriteLine(resultado);




   Console.ReadKey();

 *
 *
 *
 *
 * 5)
 * int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

   Action<int> apenasPares = (num) => Console.WriteLine(num % 2 == 0 ? num : "");

   Array.ForEach(numeros,apenasPares);


  
  
  6)
  
  Func<int, int, int> operacao = (x, y) => x + y;
   
   Console.WriteLine($"Resultado:{Operar(10,20,operacao)}");
   
   operacao = (x, y) => x - y;
   
   Console.WriteLine($"Resultado:{Operar(10,10,operacao)}");
   
   static int Operar(int num1, int num2, Func<int, int, int> operacao)
   {
     return operacao(num1, num2);
   }



7)

using exersice_Delegate_Linq_Event_Lambda;
   
   var planetas = Planetas.GetPlanetas();
   
   Predicate<Planetas> planetasPequenos = p => p.Diametro < 10000;
   Predicate<Planetas> planetasMaiores = p => p.Diametro > 50000;
   Predicate<Planetas> planetaBaixaMassa = p => p.Massa > 1e24;
   Predicate<Planetas> planetasMassivo = p => p.Massa > 1e26;
   Predicate<Planetas> planetasPequenoseLeves = p => p.Diametro < 10000 && p.Massa < 1e24;
   
   
   Criteiro(planetasPequenos,planetas);
   Criteiro(planetasMaiores,planetas);
   Criteiro(planetaBaixaMassa,planetas);
   Criteiro(planetasMassivo,planetas);
   Criteiro(planetasPequenoseLeves,planetas);
   
   
   Console.ReadKey();
   
   
   static void Criteiro(Predicate<Planetas> criterio,List<Planetas> planetas)
   {
     Console.WriteLine("---------------------------------------");
     var result = planetas.FindAll(criterio).ToList();
     result.ForEach(p => Console.WriteLine($"{p.Nome} - {p.Massa} - {p.Diametro}"));
   }


 8)
  R = a
  
  
  9)
  using exersice_Delegate_Linq_Event_Lambda;
   
   var listNumbers = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,15,16,17,18,19,20};
   
   Console.WriteLine(listNumbers.SumOdd());





10)


using exersice_Delegate_Linq_Event_Lambda;
   
   var listStrings = Planetas.GetPlanetas();
   
   1)
   var containsA = listStrings.Where(p => p.Nome.Contains('a'));
   
   2)
   var orderPlanets = listStrings.OrderBy(p => p.Diametro).ThenBy(p => p.Massa);
   
   3)
   var groupbyLenghtStringPlanet = listStrings.GroupBy(p => p.Nome.Length);
   
   4)
   var firstOrDefaultMassPlanet = listStrings.FirstOrDefault(p => p.Massa % 2 == 0);
   
   
   Console.WriteLine("---------------- PRIMEIRO PLANETA MASSA PAR ------------------");
   if (firstOrDefaultMassPlanet != null)
     Console.WriteLine($"{firstOrDefaultMassPlanet.Nome} - {firstOrDefaultMassPlanet.Diametro}  - {firstOrDefaultMassPlanet.Massa}");
   else
     Console.WriteLine("Nenhum planeta com massa par foi encontrado");
   
   Exibir(containsA);
   Exibir(orderPlanets);
   ExibirGroup(groupbyLenghtStringPlanet);
   
   
   
   
   
   static void Exibir(IEnumerable<Planetas> collection)
   {
     Console.WriteLine("----------------------------------");
     foreach (var value in collection)
     {
       Console.WriteLine($"{value.Nome} - {value.Massa} - {value.Diametro}");
     }
   }
   
   
   static void ExibirGroup(IEnumerable<IGrouping<int, Planetas>> collection)
   {
     Console.WriteLine("----------------------------------");
     foreach (var key in collection)
     {
       Console.WriteLine($"{key.Key}");
   
       foreach (var value in key)
       {
         Console.WriteLine($"{value.Nome} - {value.Diametro} - {value.Massa}");
       }
     }
   }
   
   

 */




