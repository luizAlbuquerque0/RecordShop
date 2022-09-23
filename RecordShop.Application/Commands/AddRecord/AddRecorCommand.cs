using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Application.Commands.AddRecord
{
    public class AddRecorCommand : IRequest<int>
    {
        public int IdStore { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Band { get; set; }
        public string Album { get; set; }
        public int Amount { get; set; }
    }
}
