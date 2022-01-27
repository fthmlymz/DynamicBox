using Microsoft.AspNetCore.Mvc;

namespace DynamicBox.Workflow.Shared.Dtos
{
    public class CustomControllerBase: ControllerBase
    {

        public IActionResult CreateActionResultInstance<T>(ServiceResponse<T> response)
        {
            if (response.StatusCode == 204)
            {
                return NoContent();
            }

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
