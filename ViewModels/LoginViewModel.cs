using System.ComponentModel.DataAnnotations;

namespace Chapter1000ton.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o endereço de e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }
    }
}
