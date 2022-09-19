using RecordShop.Core.Entities;

namespace RecordShop.Core.Repositories
{
    public interface IRecordRepository
    {
        Task<Record> GetById(int id);
        Task<List<Record>> GetByTitleAndBandAsync(string query);
        Task<List<Record>> GetAllAsync();
        Task AddRecordAsync(Record record);
        Task DeleteRecordAsync(int id);

    }
}
