namespace challenge_backend.Models
{
    public class Pedido
    {
        public List<Producto> Productos { get; set; }
        public int VendedorId { get; set; }
    }
}
