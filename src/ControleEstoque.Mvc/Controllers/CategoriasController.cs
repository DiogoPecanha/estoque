using ControleEstoque.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.Mvc.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
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