using MediatR;
using RecordShop.Application.ViewModels;
using RecordShop.Infrastructure.Persistence.Repositories;

namespace RecordShop.Application.Queries.GetRecordByTitleOrBand
{
    public class GetRecordByTitleOrBandQueryHandler : IRequestHandler<GetRecordByTitleOrBandQuery, List<RecordViewModel>>
    {
        private readonly RecordRepository _recordRepository;
        public GetRecordByTitleOrBandQueryHandler(RecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }
        public async Task<List<RecordViewModel>> Handle(GetRecordByTitleOrBandQuery request, CancellationToken cancellationToken)
        {
            var records = await _recordRepository.GetByTitleAndBandAsync(request.Query);

            var recordsViewModel = records.Select(r => new RecordViewModel(r.Name, r.Price, r.Amount, r.Band, r.Album, "mudar")).ToList();

            return recordsViewModel;
        }
    }
}
