namespace Mehedi.EventBus;


public interface IEventProducer
    {
        Task PublishAsync(IntegrationEvent @event, CancellationToken cancellationToken = default);
    }


