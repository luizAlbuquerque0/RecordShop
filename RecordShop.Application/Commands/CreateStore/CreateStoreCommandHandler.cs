using MediatR;
using RecordShop.Core.Entities;
using RecordShop.Core.Repositories;

namespace RecordShop.Application.Commands.CreateStore
{
    public class CreateStoreCommandHandler : IRequestHandler<CreateStoreCommand, int>
    {
        private readonly IStoreRepository _storeRepository;
        public CreateStoreCommandHandler(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public async Task<int> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            var store = new Store(request.Name, request.Email, request.Password, request.Phone, request.Adress);

            await _storeRepository.CreateStoreAsync(store);

            return store.Id;
        }
    }
}
