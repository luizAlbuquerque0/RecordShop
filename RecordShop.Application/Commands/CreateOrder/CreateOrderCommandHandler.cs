using MediatR;
using RecordShop.Core.Entities;
using RecordShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Application.Commands.CreateOrder
{
    internal class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IOrderRepository _orderRepository;
        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(request.IdCLient, request.IdStore, request.TotalCost, request.PaymentMethod, request.Observations);

            await _orderRepository.CreateOrderAsync(order);

            return order.Id;
        }
    }
}
