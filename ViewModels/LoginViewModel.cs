using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DwitterLoungeBar.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please provide username")]
        [DisplayName("Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Please provide password")]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }
        public string? ReturnUrl { get; set; }

    }
}
