namespace Mehedi.EventBus;


public interface IEventProducer
    {
        Task<bool> PublishAsync(IntegrationEvent @event, CancellationToken cancellationToken = default);
    }


