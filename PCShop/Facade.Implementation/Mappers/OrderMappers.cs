using Facade.Contracts.DTOs;
using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Implementation.Mappers
{
    public static class OrderMappers
    {
        public static OrderDto ToDto(this Order order)
        {
            return new OrderDto
            {
                ClientId = order.ClientId,
                DestinationCountry = order.DestinationCountry,
                Id = order.Id,
                PcId = order.PcId,
                Quantity = order.Quantity
            };
        }


        public static IEnumerable<OrderDto> ToDtos(this IEnumerable<Order> orders)
        {
            return orders.Select(c => c.ToDto());
        }
    }
}
