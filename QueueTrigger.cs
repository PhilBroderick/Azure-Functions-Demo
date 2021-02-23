using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace azure_functions_demo
{
    public static class QueueTrigger
    {
        [FunctionName("QueueTrigger")]
        public static void Run([QueueTrigger("my-queue", Connection = "")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
