/*
    1) resposta -> 1 e 3
    
    
    
    
    2) resposta -> d
    ao somar o valor 1 ao Campo, ira gerar um erro em tempo de compilação, pois T pode ser qualquer coisa e não a uma definição explicita para ele se comporta nessa situação
    
    Ex:
    1+1 ok
    1 + Class ? error
    
    
    
    
    3) resposta -> c
    
    
    
    
    4) resposta -> a
    Teste teste = new Teste();
    teste.MetodoTeste<string>("Usando Generics ->");
    teste.MetodoTeste<float>(4.2f);
   
   public class Teste
   {
       public void MetodoTeste<T>(T arg)
       {
           Console.Write(arg);
       }
   }
    
    
    
    
    
   5) resposta -> c
   Generic<string> g = new Generic<string>();
   g.Campo = "Exercicio Generic";
   Console.WriteLine(g.Campo);
   public class Generic<T>
   {
       public T? Campo;
   }
   
   
   
   
    6) resposta -> d
    O código acima restringe a classe MeuContainer a trabalhar apenas com tipos que são classes de referência e que implementam a interface IComparable.
    
    7) resposta -> c
    -) Generics transferem o ônus da segurança de tipo para o programador em vez do compilador.
   Falso. Na verdade, o compilador verifica os tipos em tempo de compilação, reduzindo o risco de erros e transferindo a responsabilidade para o compilador, não para o programador.
   
   b-) Generics requerem o uso de conversão de tipo explícito.
   Falso. Genéricos eliminam a necessidade de conversão explícita porque o tipo é conhecido em tempo de compilação.
   
   d-) Generics eliminam a possibilidade de erros de execução.
   Falso. Embora reduzam muitos erros relacionados a tipos, eles não eliminam completamente todos os erros de execução, como erros de lógica.
   
   e-) Nenhuma das acima.
   Falso. Como a letra c está correta, essa opção está descartada.
    
    
    
    8)
  
   Numbers<int> n = new Numbers<int>();
   n.AddNumbers(2);
   n.AddNumbers(3);
   
   Console.WriteLine(n[0]);
   Console.WriteLine(n[1]);
   
    public class Numbers<T> where T : struct
   {
       T[] array = new T [2];
       int count = 0;
   
       public void AddNumbers( T value)
       {
           if (count < array.Length)
           {
               array[count] = value;
           }
           count++;
       }
       
       public T this[int index]
       {
           get => array[index]; 
           set => array[index] = value;
       }
   
   }
   
   
   
   
   
   
   
   
   
   9)
   var st1 = new Student("Álife",23,"Masculino");
   var st2 = new Student("Bob",18,"Masculino");
   var st3 = new Student("Cassia",21,"Feminino");
   var st4 = new Student("Ana",21,"Feminino");
   var st5 = new Student("Lucas",30,"Masculino");
   
   var rep = new RepositoryStudent();
   rep.AddStudent(1,st1);
   rep.AddStudent(2,st2);
   rep.AddStudent(3,st3);
   rep.AddStudent(4,st4);
   rep.AddStudent(5,st5);
   rep.ShowStudents();
   
   
   public class RepositoryStudent
   {
       private  readonly Dictionary<int, Student> _students;
       
       public RepositoryStudent()
       {
           _students = new Dictionary<int, Student>();
       }
   
       public bool AddStudent(int key,Student student)
       {
           if(!_students.ContainsKey(key))
           {
               _students.Add(key, student);
               return true;
           }
           return false;
       }
   
       public  void ShowStudents()
       {
           foreach (var value in _students)
           {
               Console.WriteLine($"{value.Key}-{value.Value.Nome},{value.Value.Idade},{value.Value.Sexo}");
           }
       }
   }
   
   public class Student
   {
       private string? _nome;
       private int _idade;
       private string? _sexo;
       
       public string Nome
       {
           get => string.IsNullOrEmpty(_nome) ? "Nome do Aluno" : _nome; 
           set => _nome = value;
       }
   
       public int Idade
       {
           get => _idade > 0 ? _idade : 0;
           set => _idade = value;
       }
   
       public string Sexo
       {
           get => string.IsNullOrEmpty(_sexo) ? "Sexo do Aluno" : _sexo;
           set => _sexo = value;
       }
   
       public Student(string nome, int idade, string sexo)
       {
           Nome = nome;
           Idade = idade;
           Sexo = sexo;
       }
   }
   
   
   
   
   
   
   
   
   10)
   string expression = "x =( -b ± sqrt(b^2 - 4ac)) / (2a)";
   if (AreParenthesesBalanced(expression))
       Console.WriteLine("Parênteses Balanceados");
   else
       Console.WriteLine("Parênteses NÃO Balanceados");
   
   
   static bool AreParenthesesBalanced(string expression)
   {
       var bracketStack = new Stack<char>();
       var matchingBrackets = new Dictionary<char, char>
       {
           { ')', '(' },
           { '}', '{' },
           { ']', '[' }
       };
   
       foreach (var ch in expression)
       {
           if (matchingBrackets.ContainsValue(ch)) // Abertura
           {
               bracketStack.Push(ch);
           }
           else if (matchingBrackets.ContainsKey(ch)) // Fechamento
           {
               if (bracketStack.Count == 0 || bracketStack.Peek() != matchingBrackets[ch])
               {
                   return false; // Não balanceado
               }
               bracketStack.Pop();
           }
       }
   
       return bracketStack.Count == 0; // Balanceado se a pilha estiver vazia
   }
   
   
   
   
   
   
   
   
   
   
   
   11)
   var queuePrint = new Queue<string>();
   
   queuePrint.Enqueue("Relatório_Financeiro.pdf\n");
   queuePrint.Enqueue("TCC_Revisão_Final.pdf\n");
   queuePrint.Enqueue("Foto_de_Viagem.jpg\n");
   queuePrint.Enqueue("Planilha_Vendas_2024.xlsx\n");
   queuePrint.Enqueue("Curriculo_João_Silva.docx\n");
   
   while (queuePrint.Count > 0)
   {
       var count = 0;
       if (!(queuePrint.Count < 0))
       {
           var file = queuePrint.Dequeue();
           Console.WriteLine($"Arquivo {file} esta sendo impresso...");
           Thread.Sleep(3000);
           Console.WriteLine($"Arquivo {file} foi impresso com sucesso!");
           count++;
       }
   
   }
   
*/









using System.Threading.Channels;
/*
var stackExpressions = new Stack<char>();

var oneExpression = "x =( -b \u00b1 sqrt(b^2 - 4ac)) / (2a)";
var clear = true;
for(var i = 0; i < oneExpression.Length; i++)
{

    if (oneExpression[i] == '(' || oneExpression[i] == '{' || oneExpression[i] == '[')
    {
        stackExpressions.Push(oneExpression[i]);
    }

    if (oneExpression[i] == ')' || oneExpression[i] == '}' || oneExpression[i] == ']')
    {
        if ((oneExpression.Count(c => c == '(') != (oneExpression.Count(c => c == ')'))))
        {
            clear = false;
        }
        if (!(stackExpressions.Count <= 0))
        {
            Console.WriteLine($"{stackExpressions.Peek()},{oneExpression[i]}");
            if (string.Concat(stackExpressions.Peek(), oneExpression[i]) == "()" || string.Concat(stackExpressions.Peek(), oneExpression[i])== "{}" || string.Concat(stackExpressions.Peek(), oneExpression[i]) == "[]" )
            {
                 stackExpressions.Pop(); 
            }
            
        }
      
    }
}

if(stackExpressions.Count <= 0 && clear)
    Console.WriteLine("Parênteses Balanceados");
else
    Console.WriteLine("Parênteses NÃO! Balanceados");
*/
/*
static void ShowTargetCollection<T>(IEnumerable<T> collection)
{
    
    foreach (var value in collection)
    {
        
        Console.WriteLine(value);
    }
}
*/

int[] arr1 = { 1, 2, 3, 4, 5 };

string[] arr2 = { "one", "two", "three", "four", "five" };

double[] arr3 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };


Console.WriteLine("Invocação explicita de tipo");
Exemplo.ReverterEImprimir<int>(arr1);
Exemplo.ReverterEImprimir<string>(arr2);

Console.WriteLine("Com inferencia de tipos");
Exemplo.ReverterEImprimir(arr1);
Exemplo.ReverterEImprimir(arr2);

public class Exemplo
{
    public static void ReverterEImprimir<T>(T[] array)
    {
        var reversedArray = array.Reverse();
        Console.WriteLine(string.Join(" ", reversedArray));
    }
}





























