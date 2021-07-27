using ControleEstoque.Database.Context;
using ControleEstoque.Domain.Models;
using ControleEstoque.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ControleEstoque.Database.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext db;

        public UsuarioRepository(AppDbContext dbContext)
        {
            db = dbContext;
        }

        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<Usuario> ObterPorId(string id)
        {
            return await db.Usuarios.FindAsync(id);
        }

        public async Task<IEnumerable<Usuario>> ObterTodos()
        {
            return await db.Usuarios.ToListAsync();
        }
    }
}
