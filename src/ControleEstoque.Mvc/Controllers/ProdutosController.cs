﻿using ControleEstoque.Domain.Services;
using PagedList;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Linq;
using ControleEstoque.Mvc.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using ControleEstoque.Domain.Models;

namespace ControleEstoque.Mvc.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly IProdutoService produtoService;
        private readonly ICategoriaService categoriaService;

        public ProdutosController(IProdutoService produtoService, ICategoriaService categoriaService)
        {
            this.produtoService = produtoService;
            this.categoriaService = categoriaService;
        }
        // GET: Produtos
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            var categorias = await categoriaService.ObterTodos();

            ViewBag.UnidadesMedida = Enum.GetNames(typeof(UnidadeMedidaDto));
            ViewBag.Categorias = categorias.Select(x => new { Codigo = x.Codigo, Nome = x.Nome }); 
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "codigo" : "";            

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var lista = await produtoService.ObterDadosPaginados(sortOrder, searchString);
            var produtos = lista.Select(p => new ProdutoViewModel() 
            { 
                Codigo = p.Codigo,
                Categoria = p.Categoria.Nome,
                Descricao = p.Descricao,
                Nome = p.Nome,
                Quantidade = p.Quantidade
            });

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(produtos.ToPagedList(pageNumber, pageSize));
        }

        public async Task<ActionResult> Salvar(ProdutoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var produto = new Produto()
                {
                    Codigo = model.Codigo,
                    UnidadeMedida = (UnidadeMedida)Enum.Parse(typeof(UnidadeMedida), model.UnidadeMedida.ToString(), true),
                    Categoria = await categoriaService.ObterPorCodigo(Convert.ToInt64(model.Categoria)),
                    Descricao = model.Descricao,
                    Nome = model.Nome,
                    Quantidade = model.Quantidade
                };

                await produtoService.Criar(produto);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        private void AddErrors(string error)
        {
            ModelState.AddModelError("", error);
        }
    }
}