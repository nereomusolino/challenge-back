using challenge_backend.Models;
using challenge_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace challenge_backend.Controllers
{
    [ApiController]
    [Route("api/challenge-backend/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService, ILogger<PedidoController> logger)
        {
            _logger = logger;
            _pedidoService = pedidoService;
        }

        [HttpGet("getProductos")]
        public IActionResult GetProductos()
        {
            try
            {
                var productos = _pedidoService.GetProductos();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("guardarPedido")]
        public IActionResult PostPedido([FromBody] Pedido pedido)
        {
            try
            {
                var productos = _pedidoService.PostPedidos(pedido);
                return Ok(productos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
