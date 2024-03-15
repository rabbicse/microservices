using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Application.UseCases.Orders.Repositories;
using Ordering.Domain.Aggregates.OrderAggregate;
using Ordering.Domain.Common;
using Ordering.Domain.ValueObjects;

namespace Ordering.Application.UseCases.Orders.Commands
{
    // Regular CommandHandler
    public class CreateOrderCommandHandler: IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IOrderCommandRepository _orderRepository;
        //private readonly IIdentityService _identityService;
        private readonly IMediator _mediator;
        //private readonly IOrderingIntegrationEventService _orderingIntegrationEventService;
        private readonly ILogger<CreateOrderCommandHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        // Using DI to inject infrastructure persistence Repositories
        public CreateOrderCommandHandler(IMediator mediator,
            //IOrderingIntegrationEventService orderingIntegrationEventService,
            IOrderCommandRepository orderRepository,
            //IIdentityService identityService,
            IUnitOfWork unitOfWork,
            ILogger<CreateOrderCommandHandler> logger)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            //_identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            //_orderingIntegrationEventService = orderingIntegrationEventService ?? throw new ArgumentNullException(nameof(orderingIntegrationEventService));
            _unitOfWork = unitOfWork;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Handler will handle the following processes
        /// - Validate command
        /// - Prepare objects to save
        /// - Store to event store DB
        /// - Publish events to message broker
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            #region Validate command
            #endregion

            #region Prepare Objects to save
            // Add/Update the Buyer AggregateRoot
            // DDD patterns comment: Add child entities and value-objects through the Order Aggregate-Root
            // methods and constructor so validations, invariants and business logic 
            // make sure that consistency is preserved across the whole aggregate
            var address = new Address(command.Street, command.City, command.State, command.Country, command.ZipCode);
            var order = new Order(command.UserId, command.UserName, address, command.CardTypeId, command.CardNumber, 
                command.CardSecurityNumber, command.CardHolderName, command.CardExpiration);

            foreach (var item in command.OrderItems)
            {
                order.AddOrderItem(item.ProductId, item.ProductName, item.UnitPrice, item.Discount, item.PictureUrl, item.Units);
            }
            _logger.LogInformation("Creating Order - Order: {@Order}", order);
            #endregion

            #region Save to persistance database
            await _orderRepository.InsertAsync(order);
            return await _unitOfWork.SaveEntitiesAsync(cancellationToken);
            #endregion

            #region Store event to eventstore database
            #endregion
        }
    }
}
