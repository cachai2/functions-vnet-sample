using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class ServiceBusQueueTriggerCSharp1
    {
        [FunctionName("ServiceBusQueueTriggerCSharp1")]
        public static void Run([ServiceBusTrigger("queue", Connection = "linuxsbcachai_SERVICEBUS")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
