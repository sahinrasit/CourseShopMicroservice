using CourseShop.Services.Order.Application.Dtos;
using CourseShop.Shared.Dtos;
using MediatR;

namespace CourseShop.Services.Order.Application.Queries
{
    public class GetOrdersByUserIdQuery : IRequest<Response<List<OrderDto>>>
    {
        public string UserId { get; set; }
    }
}
