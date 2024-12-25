using pooExercicios;
using static System.Net.WebRequestMethods;

/*
 * 
 *  1) Sealed
 *  2) New
 *  3) D
 *  4) O metodo exibir da classe A não foi executado, o resultado na tela foi 2, devido a classe B oculta-lo
 *  5) A e B
 *  6) 1,2,5
 *  
 *
 *4)
 *B b = new B();
b.i = 1;
b.j = 2;
b.Exibir();
Console.ReadKey();
public class A
{
    public int i;
    public void Exibir()
    {
        Console.WriteLine(i);
    }
}

public class B : A
{
    public int j;
    public new void Exibir()
    {
        Console.WriteLine(j);
    }

 * 5)
 * A a = new A();
   B b = new B();
   A x;
   x = a;// new A()
   x.Exibir(); // A
   x = b; // new B()
   x.Exibir(); // B

   class A
{
    public virtual void Exibir()
    {
        Console.WriteLine("A");
    }
}
class B : A
{
    public override void Exibir()
    {
        Console.WriteLine(" B ");
    }
}

-----------------------------------------------------------------


Exercicio 2)

LivroFotos livroFotos = new LivroFotos();
livroFotos.GetExibirNumeroPaginas();

LivroFotos livroFotos1 = new LivroFotos(24);
livroFotos1.GetExibirNumeroPaginas();

SuperLivroFotos superLivroFotos = new SuperLivroFotos();
superLivroFotos.GetExibirNumeroPaginas();


 */


/*
 * 
 *  1) Sealed
 *  2) New
 *  3) D
 *  4) O metodo exibir da classe A não foi executado, o resultado na tela foi 2, devido a classe B oculta-lo
 *  5) A e B
 *  6) 1,2,5
 *  
 *
 *4)
 *B b = new B();
b.i = 1;
b.j = 2;
b.Exibir();
Console.ReadKey();
public class A
{
    public int i;
    public void Exibir()
    {
        Console.WriteLine(i);
    }
}

public class B : A
{
    public int j;
    public new void Exibir()
    {
        Console.WriteLine(j);
    }

 * 5)
 * A a = new A();
   B b = new B();
   A x;
   x = a;// new A()
   x.Exibir(); // A
   x = b; // new B()
   x.Exibir(); // B

   class A
{
    public virtual void Exibir()
    {
        Console.WriteLine("A");
    }
}
class B : A
{
    public override void Exibir()
    {
        Console.WriteLine(" B ");
    }
}

------------------------------------------------------------------

Exercicio 1)

Console.WriteLine("Digite a quantidade inicial de gasolina");
int qtdG = Convert.ToInt32(Console.ReadLine());
Carro c1 = new Carro(0);
c1.Abastecer(qtdG);
c1.Dirigir();

------------------------------------------------------------------

Exercicio 2)

LivroFotos livroFotos = new LivroFotos();
livroFotos.GetExibirNumeroPaginas();

LivroFotos livroFotos1 = new LivroFotos(24);
livroFotos1.GetExibirNumeroPaginas();

SuperLivroFotos superLivroFotos = new SuperLivroFotos();
superLivroFotos.GetExibirNumeroPaginas();

-------------------------------------------------------------------

Exercicio 3)

Console.WriteLine("Digite o nome do Aluno");
string a1 = Console.ReadLine() ?? String.Empty;
Console.WriteLine("Digete o nome do segundo Aluno");
string a2 = Console.ReadLine() ?? String.Empty;
Console.WriteLine("Digite o nome do professor");
string p1 = Console.ReadLine() ?? String.Empty;

Pessoa[,] pessoas = new Pessoa[1,3];

for (int i = 0; i < pessoas.GetLength(0); i++)
{
    for (int j = 0; j < pessoas.GetLength(1); j++)
    {
        pessoas[0, 0] = new Aluno(a1);
        pessoas[0, 1] = new Aluno(a2);
        if (pessoas.GetLength(1) > 2)
        {
            pessoas[0, 2] = new Professor(p1);
        }
    }
}

(pessoas[0, 0] as Aluno)?.Estudar();
(pessoas[0, 1] as Aluno)?.Estudar();
(pessoas[0, 2] as Professor)?.Explicar();


-------------------------------------------------------------------

Exercicío 4)

List<Pessoa> pessoas = new List<Pessoa>();

for(int i  = 0; i<3; i++)
{   
        String nome = Console.ReadLine() ?? String.Empty;
        pessoas.Add(new Pessoa(nome));
}

foreach(var pessoa in pessoas)
{

    Console.WriteLine(pessoa.ToString());
}

Exercicío 5)

SqlServer sqlServer = new SqlServer();
/*
sqlServer.Port = 3000;
sqlServer.Url = "http://localhost";
sqlServer.Conectar();
sqlServer.Configurar();


Exercicio 6)

Ao instanciar B e passar "Olá Mundo..." no parametro da instancia a classe b chama o construdor da classe A atraves do metodo base(s)

Exercicio 7)

O codigo ira gerar um error, devido os metodos abstratos da interfaces terem o mesmo nome gerando um conflito de assinatura

Necessita de um identificador de interface

void INota1.Classificacao()

INota1 p = new Exibir();
p.Classificacao();
(p as INota2)?.Classificacao();

Exercicio 8)

Não, ira ocorrer um estouro de pilha, pois ocorrera uma chamada ciclica entre o Movel e Cadeira, pois o Movel instancia Cadeira em seu codigo que chama a classe cadeira que chama a classe Movel ate a memoria estourar

public class Movel
{

    Cadeira cadeira = new Cadeira();
    public Movel()
    {
        Console.WriteLine("Construtor classe pai");
    }

}


public Cadeira()
{
    Console.WriteLine("Construtor Filha");
}
Cadeira cadeira = new Cadeira();



Exercicio 9)



*/





Console.ReadKey();
















