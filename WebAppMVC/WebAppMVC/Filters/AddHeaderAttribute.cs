
namespace WebAppMVC.Filters
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class AddHeaderAttribute : ActionFilterAttribute
    {
        public string Name { get; init; }

        public string Value { get; init; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add($"BeforeAction-{this.Name}", this.Value);

            if (context.HttpContext.Request.Query.ContainsKey("Invalid"))
            {
                context.Result = new BadRequestResult();
            }

            base.OnActionExecuting(context);
        }

        
    }
}
