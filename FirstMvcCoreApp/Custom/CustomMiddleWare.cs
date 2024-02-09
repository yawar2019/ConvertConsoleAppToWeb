namespace FirstMvcCoreApp.Custom
{
    public class CustomMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("the custome Middleware Called 1st time\n");
            await next(context);
            await context.Response.WriteAsync("the custome Middleware Called 2nd time\n");

        }
    }
}
