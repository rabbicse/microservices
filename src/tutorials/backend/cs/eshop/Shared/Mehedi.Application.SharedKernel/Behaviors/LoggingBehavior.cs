using MediatR;
using Mehedi.Application.SharedKernel.Extensions;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Mehedi.Application.SharedKernel.Behaviors;

public class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
    : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger = logger;

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var commandName = request.GetGenericTypeName();

        _logger.LogInformation("----- Handling command '{CommandName}'", commandName);

        var timer = new Stopwatch();
        timer.Start();

        var response = await next();

        timer.Stop();

        var timeTaken = timer.Elapsed.TotalSeconds;
        _logger.LogInformation("----- Command '{CommandName}' handled ({TimeTaken} seconds)", commandName, timeTaken);

        return response;
    }
}
