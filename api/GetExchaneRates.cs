using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Convert
{
    public class GetExchaneRates
    {
        private readonly ILogger<GetExchaneRates> _logger;

        public GetExchaneRates(ILogger<GetExchaneRates> logger)
        {
            _logger = logger;
        }

        [Function("GetExchaneRates")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
