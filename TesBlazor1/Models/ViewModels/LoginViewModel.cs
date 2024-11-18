using System.ComponentModel.DataAnnotations;

namespace TesBlazor1.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please input Username!")]
        public string? Username { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please input Password!")]
        public string? Password { get; set; }
    }
}
