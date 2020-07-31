using System;
using System.Collections;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace triggerQueue
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static void Timer(
            [TimerTrigger("5 * * * * *")]TimerInfo myTimer, 
            [Queue("myqueue-items", Connection = "AzureWebJobsStorage")] IAsyncCollector<string> collector,
            ILogger log
            )
        {
            collector.AddAsync($"En-Colado - {DateTime.Now}");             
        }
    }
}
