using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace VideoGameStore.Models
{
    //------------------------------------
    // User class is an Identity user type
    //------------------------------------
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Please enter a first name")]
        [StringLength(30)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name")]
        [StringLength(30)]
        public string LastName { get; set; } = string.Empty;

        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}
