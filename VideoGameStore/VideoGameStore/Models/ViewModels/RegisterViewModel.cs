using System.ComponentModel.DataAnnotations;


namespace VideoGameStore.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please Enter a User name")]
        [MaxLength(30)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter a First Name")]
        [MaxLength(30)]
        public string Firstname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter a Last Name")]
        [MaxLength(30)]
        public string Lastname { get; set; } = string.Empty;

        // from identity user class
        [Required(ErrorMessage = "Please Enter an Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter a Password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Confirm your Password")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
