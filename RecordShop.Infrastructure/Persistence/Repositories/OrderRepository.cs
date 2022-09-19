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
    public class OrderRepository : IOrderRepository
    {
        private readonly RecordShopDbContext _dbContext;
        public OrderRepository(RecordShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateOrderAsync(Order order)
        {
            await _dbContext.Orders.AddAsync(order);
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _dbContext.Orders.SingleOrDefaultAsync(o => o.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
