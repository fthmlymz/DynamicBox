using DynamicBox.IdentityServer.Models;
using IdentityModel;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DynamicBox.IdentityServer.Services
{
    public class IdentityResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IdentityResourceOwnerPasswordValidator(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            //Önce kullanıcı kontrolü
            var existedUser = await _userManager.FindByEmailAsync(context.UserName);
            if (existedUser == null)
            {
                var errors = new Dictionary<string, object>();
                errors.Add("erros", new List<string> { "Email veya şifreniz yanlış" });
                context.Result.CustomResponse = errors;
                return;
            }

            //password check
            var passwordCheck = await _userManager.CheckPasswordAsync(existedUser, context.Password);
            if (passwordCheck == false)
            {
                var errors = new Dictionary<string, object>();
                errors.Add("erros", new List<string> { "Email veya şifreniz yanlış" });
                context.Result.CustomResponse = errors;
                return;
            }

            context.Result = new GrantValidationResult(existedUser.Id.ToString(), OidcConstants.AuthenticationMethods.Password);

        }
    }
}
