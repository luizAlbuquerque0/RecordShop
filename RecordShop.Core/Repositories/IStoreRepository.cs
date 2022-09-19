using RecordShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Core.Repositories
{
    public interface IStoreRepository
    {
        Task<Store> GetByIdAsync(int id);
        Task CreateStoreAsync(Store store);
        Task<User> GetStoreByEmailAndPasswordAsync(string email, string password);
        Task SaveChangesAsync();
    }
}
