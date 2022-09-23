using MediatR;
using RecordShop.Application.ViewModels;

namespace RecordShop.Application.Queries.GetRecordById
{
    public class GetRecordByIdQuery : IRequest<RecordViewModel>
    {
        public int Id { get; set; }
    }
}
