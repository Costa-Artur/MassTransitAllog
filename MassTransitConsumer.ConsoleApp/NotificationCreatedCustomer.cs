using MassTransit;
using MassTransitAllog.Shared;
using System.Text.Json;

namespace MassTransitConsumer.NotificationCreatedConsumer;

public class NotificationCreatedConsumer : IConsumer<INotificationCreated>
{
    public async Task Consume(ConsumeContext<INotificationCreated> context)
    {
        var serializedMessage = JsonSerializer.Serialize(context.Message, new JsonSerializerOptions { });

        Console.WriteLine($"Mensagem: {serializedMessage}");
    }
}