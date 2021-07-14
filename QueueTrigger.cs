using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
//Use Task.Delay when you want a logical delay without blocking the current thread
//using System.Threading.Tasks;

namespace Company.Function
{
    public static class QueueTrigger
    {
        [FunctionName("QueueTrigger")]
        public static void Run([QueueTrigger("simplequeue", Connection = "queuetriggerhandsonlabsa_STORAGE")]string myQueueItem, ILogger log)
        {
            //int DELAY = 30; // define the delay in seconds
            //Task.Delay(TimeSpan.FromSeconds(DELAY)).Wait(); //sleeping... ZzZ.. ZzZz.. zz

            log.LogInformation($"C# Queue trigger function processed: {myQueueItem} with errors");
            throw new InvalidOperationException("This a manually created exception for this function.");
        }
    }
}

// created by carlosdel@microsoft.com