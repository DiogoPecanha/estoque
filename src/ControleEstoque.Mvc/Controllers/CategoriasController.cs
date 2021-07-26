using ControleEstoque.Domain.Services;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Linq;
using ControleEstoque.Mvc.ViewModels;

namespace ControleEstoque.Mvc.Controllers
{
    [Authorize]
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

            var listaMapeada = lista.Select(c => new CategoriaViewModel()
            {
                Codigo = c.Codigo,
                Nome = c.Nome
            });

            return View(listaMapeada);
        }
    }
}