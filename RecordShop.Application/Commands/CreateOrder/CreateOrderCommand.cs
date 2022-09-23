using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Application.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<int>
    {
        public int IdCLient { get; set; }
        public int IdStore { get; set; }
        public decimal TotalCost { get; set; }
        public string PaymentMethod { get; set; }
        public string  Observations { get; set; }
    }
}
