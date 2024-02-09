using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EntregadoresAPI.Filters
{
    public class AuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.Headers.ContainsKey("UserType"))
            {
                context.Result = new UnauthorizedObjectResult(new { ErrorMessage = "É preciso estar logado" });
            }

            if(context.HttpContext.Request.Headers.TryGetValue("UserType", out var value) && value != "Admin")
            {
                context.Result = new UnauthorizedObjectResult(new { ErrorMessage = "Acesso restrito a administradores" });
            }
        }
    }
}
