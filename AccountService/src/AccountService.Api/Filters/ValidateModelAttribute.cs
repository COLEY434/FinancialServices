using AccountService.Core.DTOs.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AccountService.Api.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var allErrors = context.ModelState.Values.SelectMany(v => v.Errors).Select(k => k.ErrorMessage).ToList();
                var res = new BadRequestResponseDto
                {
                    Errors = allErrors,
                    Success = false,
                    StatusCode = 400
                };
                context.Result = new BadRequestObjectResult(res);
            }
        }
    }
}
