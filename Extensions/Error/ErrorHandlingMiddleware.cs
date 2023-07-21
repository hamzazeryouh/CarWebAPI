using Newtonsoft.Json;
using System.Net;

namespace CarWebAPI.Extensions.Error
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ErrorHandlingMiddleware> logger;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                // Log the exception
                logger.LogError(ex, "An unhandled exception occurred.");

                // Set the response status code
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                // Create an error response
                var errorResponse = new
                {
                    Message = "An error occurred while processing your request."
                };

                // Serialize the error response to JSON
                var jsonResponse = JsonConvert.SerializeObject(errorResponse);

                // Write the JSON response to the response stream
                await context.Response.WriteAsync(jsonResponse);
            }
        }
    }
    }

