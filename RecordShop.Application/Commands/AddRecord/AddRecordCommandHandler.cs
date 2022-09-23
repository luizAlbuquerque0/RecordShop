using MediatR;
using RecordShop.Core.Entities;
using RecordShop.Core.Repositories;

namespace RecordShop.Application.Commands.AddRecord
{
    internal class AddRecordCommandHandler : IRequestHandler<AddRecorCommand, int>
    {
        private readonly IRecordRepository _recordRepository;
        public AddRecordCommandHandler(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }
        public async Task<int> Handle(AddRecorCommand request, CancellationToken cancellationToken)
        {
            var record = new Record(request.IdStore, request.Name, request.Price, request.Band, request.Album, request.Amount);

            await _recordRepository.AddRecordAsync(record);

            return record.Id;
        }
    }
}
