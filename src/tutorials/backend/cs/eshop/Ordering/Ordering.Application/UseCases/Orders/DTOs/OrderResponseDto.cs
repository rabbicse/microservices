namespace Ordering.Application.UseCases.Orders.DTOs
{
    public record OrderResponseDto
    {
        public int ordernumber { get; init; }
        public DateTime date { get; init; }
        public string status { get; init; }
        public string description { get; init; }
        public string street { get; init; }
        public string city { get; init; }
        public string state { get; init; }
        public string zipcode { get; init; }
        public string country { get; init; }
        public List<OrderItemResponseDto> orderitems { get; set; }
        public decimal total { get; set; }
    }
}
