using System.Web.Mvc;

namespace Mercado.Capital.Cotacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descrição sobre a página.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Dados para contato:";

            return View();
        }
    }
}