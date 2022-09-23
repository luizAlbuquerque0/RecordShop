using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Application.Commands.CreateStore
{
    public class CreateStoreCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CNPJ { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

    }
}
