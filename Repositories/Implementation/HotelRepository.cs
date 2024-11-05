using BedBankReports.API.Data;
using BedBankReports.API.Models.Domain;
using BedBankReports.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BedBankReports.API.Repositories.Implementation
{
    public class HotelRepository : IHotelRepository
    {
        private readonly ApplicationDbContext dbContext;

        public HotelRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

       
        public async Task<IEnumerable<Hotel>> GetAllAsync()
        {

            return await dbContext.Hotels.AsNoTracking().ToListAsync();

        }

     

        public async Task<Hotel> GetByIdAsync(int id)
        {
            return await dbContext.Hotels.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> GetCount()
        {
            return await dbContext.Hotels.CountAsync();
        }


    }
}
