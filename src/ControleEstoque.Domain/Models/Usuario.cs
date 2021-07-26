using System;

namespace ControleEstoque.Domain.Models
{
    public class Usuario 
    {
        public Usuario()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Identificador unico do usuário
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Nome completo do usuario
        /// </summary>
        public string NomeCompleto { get; set; }

        /// <summary>
        /// E-mail do usuário
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        /// Apelido do usuario
        /// </summary>
        public virtual string UserName { get; set; }

        /// <summary>
        /// Senha do Usuário
        /// </summary>
        public virtual string Password { get; set; }
    }
}
