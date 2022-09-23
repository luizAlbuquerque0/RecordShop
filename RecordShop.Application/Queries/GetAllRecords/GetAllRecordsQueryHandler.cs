using MediatR;
using RecordShop.Application.ViewModels;
using RecordShop.Core.Entities;
using RecordShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Application.Queries.GetAllRecords
{
    internal class GetAllRecordsQueryHandler : IRequestHandler<GetAllRecordsQuery, List<RecordViewModel>>
    {
        private readonly IRecordRepository _recordRepository;
        public GetAllRecordsQueryHandler(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }
        public async Task<List<RecordViewModel>> Handle(GetAllRecordsQuery request, CancellationToken cancellationToken)
        {
            var records = await _recordRepository.GetAllAsync();

            var recordsViewModel = records.Select(r => new RecordViewModel(r.Name, r.Price, r.Amount, r.Band, r.Album, "mudar")).ToList();

            return recordsViewModel;
        }
    }
}
