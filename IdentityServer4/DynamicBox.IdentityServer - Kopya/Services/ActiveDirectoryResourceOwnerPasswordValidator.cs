using DynamicBox.IdentityServer.DTOs;
using IdentityModel;
using IdentityServer4.Validation;
using Microsoft.Extensions.Configuration;
using System;
using System.DirectoryServices;
using System.Threading.Tasks;

namespace DynamicBox.IdentityServer.Services
{
    public class ActiveDirectoryResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        public IConfiguration Configuration { get; }
        public ActiveDirectoryResourceOwnerPasswordValidator(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            Console.WriteLine("ldap doğrulama alanı");

            var result = IsAuthenticated(context);


            if (result)
            {
                context.Result = new GrantValidationResult(result.ToString(), OidcConstants.AuthenticationMethods.Password);
            }
            context.Result = new GrantValidationResult(result.ToString(), OidcConstants.AuthenticationMethods.Password);
            Console.WriteLine(context.Result.ToString());
        }



        public bool IsAuthenticated(ResourceOwnerPasswordValidationContext loginDto)
        {
            Console.WriteLine("ldap doğrulama alanı");
            bool result = false;
            try
            {
                string fullName = string.Format("{0}\\{1}", Configuration["ActiveDirectory:Domain"], loginDto.UserName);
                DirectoryEntry entry = new DirectoryEntry(Configuration["ActiveDirectory:Address"], fullName, loginDto.Password);
                DirectorySearcher voyager = new DirectorySearcher(entry);


                voyager.Filter = string.Format("(SAMAccountName={0})", loginDto.UserName);
                voyager.PropertiesToLoad.Add("CN");
                voyager.PropertiesToLoad.Add("givenName");

                SearchResult sR = voyager.FindOne();
                if (sR != null)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            return result;
        }





    }
}
