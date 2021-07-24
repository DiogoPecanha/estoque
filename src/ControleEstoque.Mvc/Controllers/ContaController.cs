using ControleEstoque.Mvc.ViewModels;
using System.Web.Mvc;

namespace ControleEstoque.Mvc.Controllers
{
    public class ContaController : Controller
    {
        // GET: Conta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(ContaRegistrarViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}