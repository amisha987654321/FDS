using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FDS_WebApi
{
    public sealed class CustomApiSecurity : Attribute, IAsyncActionFilter
    {
        private static string API_KEY = "okhvgb147865269306hg51";

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.HttpContext.Request.Headers.Authorization.Contains(API_KEY))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Api Key was not provided"
                };
                return;
            }

            await next();
        }
    }
}
