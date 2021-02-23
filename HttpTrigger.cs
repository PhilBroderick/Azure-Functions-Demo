using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace azure_functions_demo
{
    public static class HttpTrigger
    {
        [FunctionName("HttpFunction")]
        public static string Run(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req, 
            [Queue("my-queue")] ICollector<string> queueMessage,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var name = req.Query["name"];

            queueMessage.Add(string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.");

            return "Message has been processed!";
        }
    }
}
