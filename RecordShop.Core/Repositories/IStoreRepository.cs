using RecordShop.Core.Entities;

namespace RecordShop.Core.Repositories
{
    public interface IStoreRepository
    {
        Task<Store> GetByIdAsync(int id);
        Task CreateStoreAsync(Store store);
        Task<Store> GetStoreByEmailAndPasswordAsync(string email, string password);
        Task SaveChangesAsync();
    }
}
