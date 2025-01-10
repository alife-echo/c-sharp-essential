
using EventHandler_EventHandler_TeventArgs;

var pedido = new Pedido();

pedido.OnCriarPedido += Sms.Enviar; // inscrevendo assinantes
pedido.OnCriarPedido += Email.Enviar; // inscrevendo assinantes

pedido.CriarPedido("alifesilva90@gmail.com","94991003085"); // disparando evento e notificando assinantes


