using System.ComponentModel.DataAnnotations;

namespace DynamicBox.IdentityServer.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
