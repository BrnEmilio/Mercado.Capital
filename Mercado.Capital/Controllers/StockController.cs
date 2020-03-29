using System.Web.Mvc;

namespace Mercado.Capital.Cotacao.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            return View();
        }
    }
}