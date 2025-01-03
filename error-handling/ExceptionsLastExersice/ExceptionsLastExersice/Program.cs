/*
 * 1)a,b,c,d,e
 * 2)a,b,c,e
 *
 * 3)
 * ---------------
 *try
   {
       Console.WriteLine("Digite um valor");
       string? valor = Convert.ToString(Console.ReadLine());
       if (valor == null)
       {
           throw new ArgumentNullException("A entrada não pode ser nula.");
       }

       if (valor == string.Empty)
       {
           throw new ArgumentException("A entrada não pode estar vazia");
       }

       if (valor.Length > 0)
       {
           Console.WriteLine(valor);
       }
   }
   catch (ArgumentNullException ex)
   {
       Console.WriteLine(ex.Message);
   }
   catch (ArgumentException ex)
   {
       Console.WriteLine(ex.Message);
   }
   finally
   {
       Console.WriteLine("Fim");
   }
 *----------------
 *
 *4)
 * ---------------
 *try
   {
       Console.WriteLine("Digite a idade");
       int idade = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Digite o nome");
       string? nome = Console.ReadLine();

       if (idade < 0)
       {
           throw new ArgumentException("A idade não pode ser negativa!");
       }

       if (idade == 0)
       {
           throw new NotImplementedException("A idade não foi definida");
       }

       if (String.IsNullOrEmpty(nome))
       {
           throw new NullReferenceException("O nome não pode ser nulo! ou vazio!");
       }
   }
   catch (ArgumentException ex)
   {
       Console.WriteLine(ex.Message);
   }
   catch (NotImplementedException ex)
   {
       Console.WriteLine(ex.Message);
   }
   catch (NullReferenceException ex)
   {
       Console.WriteLine(ex.Message);
   }
 *---------------
 *
 * 5)
 *
 * -----------------------
 *
 * var numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
   foreach (var numero in numeros)
   {
       Console.Write(numero + " ");
   }

   Console.WriteLine("\n");
   try
   {
       Console.WriteLine("Digite o numero indice para acessar o valor do array");
       var numero = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine($"Valor {numeros[numero]}");

   }
   catch (Exception ex) when (ex is IndexOutOfRangeException || ex is ArgumentNullException)
   {
       Console.WriteLine("O valor esta fora do indce do array ou é nulo");
   }
   catch (Exception ex) when (ex is FormatException)
   {
       Console.WriteLine("O indice esta vazio");
   }
   finally
   {
       Console.WriteLine("Fim");
   }

   -----------------------
    
   6)
   -----------------------
   using ExceptionsLastExersice;
   
   try
   {
       int saldo = 0;
       int valorSaque = 100;
       if (valorSaque > saldo)
       {
           throw new SaldoInsuficienteException("O saldo é insuficiente para este saque.");
       }
       saldo -= valorSaque;
       Console.WriteLine("Saque efetuado com sucesso. Novo saldo: " + saldo);
   }
   catch (SaldoInsuficienteException e)
   {
       Console.WriteLine("Erro: " + e.Message);
   }
   -----------------------
   7)
   letra c)
 */



