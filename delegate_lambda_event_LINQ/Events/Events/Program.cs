

using Events;
var pedido = new Pedido();


//inscrever se em um evento é adicionar os manipuladores de evento(subscribers) a um evento
// os manipuladores de evento devem ter a mesma assinatura do delegate associado ao evento
// para adicionar um manipulador de evento a um evento, utilize o "+="
// um manipulador de evento pode ser : um metodo estatico,com instancia,anonimo ou expressão lambda
pedido.OnCriarPedido += Sms.Enviar; // inscrevendo assinantes
pedido.OnCriarPedido += Email.Enviar; // inscrevendo assinantes

pedido.CriarPedido(); // disparando evento e notificando assinantes


Console.ReadKey();



