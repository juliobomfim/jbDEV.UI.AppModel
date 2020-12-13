using Microsoft.AspNetCore.Mvc;

namespace jbDEV.UI.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("vendas")]
    public class PedidosController : Controller
    {
        [Route("pedidos")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
