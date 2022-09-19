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
    public class UserRepository : IUserRepository
    {
        private readonly RecordShopDbContext _dbContext;
        public UserRepository(RecordShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);

        }

        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string password)
        {
           return await _dbContext.Users.SingleOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
