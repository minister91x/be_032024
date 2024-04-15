namespace BE_032024
{
    public class MyCustomMiddleWare
    {
        private readonly RequestDelegate _next;
        public MyCustomMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public Task Invoke(HttpContext httpContext)
        {
            //  httpContext.Response.WriteAsync("Hello world!");
            httpContext.Response.Headers.Add("HACKER", "MRQUAN");
            return _next(httpContext);
        }

       

    }

    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseMy_CustomeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyCustomMiddleWare>();
        }
    }
}
