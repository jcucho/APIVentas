using APIVentas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVentas.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> Get()
        {
            List<Venta> ventas = new List<Venta>();
            for (int i = 1; i < 11; i++) {
                ventas.Add(new Venta { Id = i, Monto = 100 * i });
            }
            return ventas;
        }
    }
}
