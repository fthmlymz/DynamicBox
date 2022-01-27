using DynamicBox.IdentityServer.DTOs;
using DynamicBox.IdentityServer.Models;
using DynamicBox.Workflow.Shared.Dtos;
using IdentityServer.LdapExtension.UserModel;
using IdentityServer.LdapExtension.UserStore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace DynamicBox.IdentityServer.Controllers
{
    [Authorize(LocalApi.PolicyName)]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILdapUserStore userStore = null;

        public UserController(UserManager<ApplicationUser> userManager, ILdapUserStore userStore)
        {
            _userManager = userManager;
            this.userStore = userStore;
        }

        [HttpPost]
        public async Task<IActionResult> Signup(SignupDTO signupDto)
        {
            var newUser = new ApplicationUser
            {
                UserName = signupDto.Username,
                Email = signupDto.Email,
                BusinessCode = signupDto.BusinessCode
            };
            var result = await _userManager.CreateAsync(newUser, signupDto.Password);

            if (!result.Succeeded)
            {
                return BadRequest(ServiceResponse<NoContent>.Fail(result.Errors.Select(x => x.Description).ToList(), statusCode: 400));
            }

            return Ok(ServiceResponse<NoContent>.Success(201));
        }






    }
}
