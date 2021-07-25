using ControleEstoque.Domain.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ControleEstoque.Mvc.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaService categoriaService;

        public CategoriasController(ICategoriaService categoriaService)
        {
            this.categoriaService = categoriaService;
        }

        // GET: Categoria
        public async Task<ActionResult> Index()
        {
            var lista = await this.categoriaService.ObterTodos();
            return View();
        }
    }
}