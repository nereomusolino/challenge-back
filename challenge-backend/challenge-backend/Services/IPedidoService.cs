using challenge_backend.Models;

namespace challenge_backend.Services
{
    public interface IPedidoService
    {
        public List<Producto> GetProductos();
        public bool PostPedidos(Pedido pedido);

    }
}
