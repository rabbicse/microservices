namespace Mehedi.EventBus;

public interface IEventConsumer
{
    public interface IEventConsumer
    {
        Task StartConsumeAsync(CancellationToken cancellationToken = default);

        event EventReceivedHandler EventReceived;
        event ExceptionThrownHandler ExceptionThrown;
    }

    public delegate Task EventReceivedHandler(object sender, IntegrationEvent @event);
    public delegate void ExceptionThrownHandler(object sender, Exception e);
}
