using MediatR;
using RecordShop.Core.Entities;
using RecordShop.Core.Repositories;
using RecordShop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.Name, request.CPF, request.Email, request.Password, request.BirthDate);

            await _userRepository.CreateUserAsync(user);

            return user.Id;

        }
    }
}
