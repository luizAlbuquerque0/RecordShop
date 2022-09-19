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
    public class RecordRepository : IRecordRepository
    {
        private readonly RecordShopDbContext _dbContext;
        public RecordRepository(RecordShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddRecordAsync(Record record)
        {
            await _dbContext.Records.AddAsync(record);
        }

        public Task DeleteRecordAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Record>> GetAllAsync()
        {
            return await _dbContext.Records.ToListAsync();
        }

        public async Task<Record> GetById(int id)
        {
            return await _dbContext.Records.SingleOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Record>> GetByTitleAndBandAsync(string query)
        {
            return await _dbContext.Records.Where(r=> r.Name.Contains(query) || r.Band.Contains(query)).ToListAsync();
        }
    }
}
