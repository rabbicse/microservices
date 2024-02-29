using Ordering.Application.UseCases.Orders.DTOs;
using Ordering.Domain.Aggregates.OrderAggregate;
using Ordering.Domain.Enums;

namespace Ordering.Application.UseCases.Orders.Queries
{
    public interface IOrderQueries
    {
        Task<Order> GetOrderAsync(int id);

        Task<IEnumerable<OrderSummaryDto>> GetOrdersFromUserAsync(string userId);

        Task<IEnumerable<CardType>> GetCardTypesAsync();
    }
}
