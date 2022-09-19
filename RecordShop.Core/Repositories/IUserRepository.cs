using RecordShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Core.Repositories
{
    public interface IUserRepository 
    {
        Task<User> GetByIdAsync(int id);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string password);
        Task CreateUserAsync(User user);
        Task SaveChangesAsync();
        
    }
}
