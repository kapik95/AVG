namespace AVG
{
    public class LowercaseUrlsMiddleware
    {
        private readonly RequestDelegate _next;

        public LowercaseUrlsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context) 
        { 
            var request = context.Request;
            var path = request.Path.ToString();

            if(path != path.ToLower())
            {
                context.Response.Redirect(request.Scheme + "://" + request.Host + path.ToLower() + request.QueryString);
                return;
            }

            await _next(context);
        }
    }
}