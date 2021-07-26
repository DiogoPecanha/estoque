using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Mvc.ViewModels
{
    public class RegistrarViewModel
    {
        [Required]        
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmarSenha { get; set; }
    }
}