
Queue<Pedido> filaPedidos = new Queue<Pedido>();


//Adicionar pedidos na fila
filaPedidos.Enqueue(new Pedido(101,10.0));
filaPedidos.Enqueue(new Pedido(202,20.0));
filaPedidos.Enqueue(new Pedido(301,30.0));


// exibir o numero de pedidos na fila
Console.WriteLine($"Numero de pedidos  da fila {filaPedidos.Count}");

//processar pedidos na fila

while (filaPedidos.Count > 0)
{
    //retirar o proximo pedido da fila
    Pedido proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processando pedido {proximoPedido.Numero}, " + $"valor {proximoPedido.Valor}");
}

//Adicionar mais alguns pedidos na fila
filaPedidos.Enqueue(new Pedido(401,40.0));
filaPedidos.Enqueue(new Pedido(501,50.0));
filaPedidos.Enqueue(new Pedido(601,60.0));


//Lolalizar um pedido na fila
int numeroPedido = 501;
Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(p => p.Numero == numeroPedido);

if (pedidoLocalizado != null) 
    Console.WriteLine($"Pedido {numeroPedido} localizado, " + $"Valor {pedidoLocalizado.Valor}");
else
    Console.WriteLine($"Pedido {numeroPedido} não localizado na fila ");

Console.ReadKey();

class Pedido
{
    public int Numero { get; set; }
    public double Valor { get; set; }
    
    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }
}