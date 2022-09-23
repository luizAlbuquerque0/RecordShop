using MediatR;
using RecordShop.Application.ViewModels;
using RecordShop.Core.Repositories;

namespace RecordShop.Application.Queries.GetRecordById
{
    public class GetRecordByIdQueryHandler : IRequestHandler<GetRecordByIdQuery, RecordViewModel>
    {
        private readonly IRecordRepository _recordRepository;
        public GetRecordByIdQueryHandler(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public async Task<RecordViewModel> Handle(GetRecordByIdQuery request, CancellationToken cancellationToken)
        {
            var record = await _recordRepository.GetById(request.Id);

            if (record == null) return null;

            return new RecordViewModel(record.Name, record.Price, record.Amount, record.Band, record.Album, "Mudar");
        }
    }
}
