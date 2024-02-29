namespace Ordering.Application.UseCases.Orders.DTOs
{
    public record OrderSummaryDto
    {
        public int ordernumber { get; init; }
        public DateTime date { get; init; }
        public string status { get; init; }
        public double total { get; init; }
    }
}
