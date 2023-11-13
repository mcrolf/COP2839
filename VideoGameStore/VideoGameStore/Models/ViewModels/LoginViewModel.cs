using System.ComponentModel.DataAnnotations;


namespace VideoGameStore.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please Enter a User name")]
        [MaxLength(40)]
        public string Username { get; set; }= string.Empty;

        [Required(ErrorMessage = "Please Enter a Password")]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;

        public string ReturnUrl { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}
