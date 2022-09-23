using MediatR;
using RecordShop.Application.ViewModels;

namespace RecordShop.Application.Queries.GetAllRecords
{
    public class GetAllRecordsQuery : IRequest<List<RecordViewModel>>
    {
    }
}
