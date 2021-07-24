using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Mvc.ViewModels
{
    public class ContaRegistrarViewModel
    {
        [Required]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }
        
        [Required]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]   
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}