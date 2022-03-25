using System.ComponentModel.DataAnnotations;

namespace DynamicBox.IdentityServer.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Şifre doğrula")]
        [Compare("Password", ErrorMessage ="Şifre eşleştirilemedi")]
        public string ConfirmPassword { get; set; }




    }
}
