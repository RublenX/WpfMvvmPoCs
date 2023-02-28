using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using WpfMvvmNet6.Messaging.Messages;

namespace WpfMvvmNet6.Services
{
    // https://learn.microsoft.com/es-es/dotnet/architecture/microservices/multi-container-microservice-net-applications/background-tasks-with-ihostedservice
    // https://learn.microsoft.com/es-es/aspnet/core/fundamentals/host/hosted-services?tabs=visual-studio&view=aspnetcore-3.1&preserve-view=false#ihostedservice-interface
    public class SegunderoService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                WeakReferenceMessenger.Default.Send(new SegunderoChangedMessage(DateTime.Now.Second));
                await Task.Delay(1000);
            }
        }
    }
}
