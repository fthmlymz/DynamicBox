using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBox.PurchasingRequestManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {

        [NonAction]//endpoint olmadığını belirtmek için
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
            {
                return new ObjectResult(null) { StatusCode = response.StatusCode };
            }
            else if (response.StatusCode == 201)
            {

            }
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
