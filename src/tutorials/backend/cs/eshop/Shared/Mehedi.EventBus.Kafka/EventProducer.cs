using Confluent.Kafka;
using Microsoft.Extensions.Logging;
using System.Text;

namespace Mehedi.EventBus.Kafka;

public class EventProducer : IDisposable, IEventProducer
{
    private IProducer<Guid, string> _producer;
    private readonly KafkaProducerConfig _config;
    private readonly ILogger<EventProducer> _logger;

    public EventProducer(KafkaProducerConfig config, ILogger<EventProducer> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _config = config ?? throw new ArgumentNullException(nameof(config));

        var producerConfig = new ProducerConfig { BootstrapServers = config.KafkaConnectionString };
        var producerBuilder = new ProducerBuilder<Guid, string>(producerConfig);
        producerBuilder.SetKeySerializer(new KeySerializer<Guid>());
        _producer = producerBuilder.Build();
    }

    public async Task<bool> PublishAsync(IntegrationEvent @event, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(@event);

        _logger.LogInformation("publishing event {EventId} ...", @event.Id);
        var eventType = @event.GetType();

        var serialized = System.Text.Json.JsonSerializer.Serialize(@event, eventType);

        var headers = new Headers
            {
                {"id", Encoding.UTF8.GetBytes(@event.Id.ToString())},
                {"type", Encoding.UTF8.GetBytes(eventType.AssemblyQualifiedName)}
            };

        var message = new Message<Guid, string>()
        {
            Key = @event.Id,
            Value = serialized,
            Headers = headers
        };

        var result = await _producer.ProduceAsync(_config.TopicName, message, cancellationToken);
        _logger.LogInformation($"Publish event status of {@event.Id}: {result.Message.Value}");
        return result.Status == PersistenceStatus.Persisted;
    }

    public void Dispose()
    {
        _producer?.Dispose();
        _producer = null;
    }
}

