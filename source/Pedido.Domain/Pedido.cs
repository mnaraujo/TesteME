using System.Collections.Generic;
namespace Pedido.Domain{
    public class Pedido{
        string idPedido {get; set;}
        List<Item> itens {get; set;}
    }
}