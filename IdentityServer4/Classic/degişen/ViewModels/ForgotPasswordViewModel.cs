using System.ComponentModel.DataAnnotations;

namespace DynamicBox.IdentityServer.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
