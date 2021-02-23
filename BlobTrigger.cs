using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace azure_functions_demo
{
    public static class BlobTrigger
    {
        [FunctionName("BlobTrigger")]
        public static void Run([BlobTrigger("my-container/{name}", Connection = "")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name}");
        }
    }
}
