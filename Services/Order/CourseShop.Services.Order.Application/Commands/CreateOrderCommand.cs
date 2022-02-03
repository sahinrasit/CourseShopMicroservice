using CourseShop.Services.Order.Application.Dtos;
using CourseShop.Shared.Dtos;
using MediatR;

namespace CourseShop.Services.Order.Application.Commands
{
    public class CreateOrderCommand : IRequest<Response<CreatedOrderDto>>
    {
        public string BuyerId { get; set; }

        public List<OrderItemDto> OrderItems { get; set; }

        public AddressDto Address { get; set; }
    }
}
