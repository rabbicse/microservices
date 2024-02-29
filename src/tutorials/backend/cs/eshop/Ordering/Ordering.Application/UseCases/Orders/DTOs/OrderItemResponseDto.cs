namespace Ordering.Application.UseCases.Orders.DTOs
{
    public record OrderItemResponseDto
    {
        public string productname { get; init; }
        public int units { get; init; }
        public double unitprice { get; init; }
        public string pictureurl { get; init; }
    }
}
