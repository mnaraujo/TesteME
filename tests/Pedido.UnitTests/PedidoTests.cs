using Xunit;
using Pedido.Domain;

namespace Pedido.UnitTests
{
    public class PedidoTests
    {
        public void CreatePedido()
        {
            ICreatePedido pedido = new CreatePedido();
        }
    }
}