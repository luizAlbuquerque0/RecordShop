using MediatR;
using RecordShop.Application.ViewModels;

namespace RecordShop.Application.Queries.GetRecordByTitleOrBand
{
    public class GetRecordByTitleOrBandQuery : IRequest<List<RecordViewModel>>
    {
        public string Query { get; set; }
    }
}
