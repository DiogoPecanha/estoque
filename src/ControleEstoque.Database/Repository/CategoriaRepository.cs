using ControleEstoque.Database.Context;
using ControleEstoque.Domain.Models;
using ControleEstoque.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Database.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext db;

        public CategoriaRepository(AppDbContext dbContext)
        {
            db = dbContext;
        }

        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<Categoria> ObterPorId(long codigo)
        {
            return await db.Categorias.FindAsync(codigo);
        }

        public async Task<IEnumerable<Categoria>> ObterPorTermo(string termo)
        {
            return await db.Categorias.Where(c => c.Nome.Contains(termo)).ToListAsync();
        }

        public async Task<IEnumerable<Categoria>> ObterTodos()
        {
            return await db.Categorias.ToListAsync();
        }

        public async Task<Categoria> Criar(Categoria categoria)
        {
            db.Categorias.Add(categoria);
            await db.SaveChangesAsync();
            return categoria;
        }
    }
}
