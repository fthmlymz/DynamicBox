using DynamicBox.STS.Identity.Configuration;
using System.ComponentModel.DataAnnotations;
using DynamicBox.Shared.Configuration.Identity;

namespace DynamicBox.STS.Identity.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        public LoginResolutionPolicy? Policy { get; set; }
        //[Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Username { get; set; }
    }
}






