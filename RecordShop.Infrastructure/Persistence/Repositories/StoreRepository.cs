using Microsoft.EntityFrameworkCore;
using RecordShop.Core.Entities;
using RecordShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Infrastructure.Persistence.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly RecordShopDbContext _dbContext;
        public StoreRepository(RecordShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateStoreAsync(Store store)
        {
            await _dbContext.AddAsync(store);
        }

        public async Task<Store> GetByIdAsync(int id)
        {
            return await _dbContext.Stores.SingleAsync(s => s.Id == id);
        }

        public async Task<Store> GetStoreByEmailAndPasswordAsync(string email, string password)
        {
            return await _dbContext.Stores.SingleOrDefaultAsync(s => s.Email == email && s.Password == password);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
