using jbDEV.UI.Site.Models;

namespace jbDEV.UI.Site.Data
{
    public class PedidoRep : IPedidoRep
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }
    }

    public interface IPedidoRep
    {
        Pedido ObterPedido();
    }
}
