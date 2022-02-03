﻿using AutoMapper;
using CourseShop.Services.Order.Application.Dtos;
using CourseShop.Services.Order.Domain.OrderAggregate;

namespace CourseShop.Services.Order.Application.Mapping
{
    internal class CustomMapping : Profile
    {
        public CustomMapping()
        {
            CreateMap<Domain.OrderAggregate.Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}