using BedBankReports.API.Data;
using BedBankReports.API.Models.Domain;
using BedBankReports.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BedBankReports.API.Repositories.Implementation
{
    public class SaleRepository : ISaleRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SaleRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public async Task<IEnumerable<Sale>> GetAllAsync()
        {
            return await dbContext.Sales.AsNoTracking().ToListAsync();
        }

        public async Task<Sale> GetByDateAsync(DateOnly date)
        {
            var saleDate = new DateOnly(date.Year, date.Month, date.Day);
            //var x=  dbContext.Sales.Any(x => x.Date.Equals(date));
         // var sale= await  dbContext.Database.SqlQuery<Sale>($"select * from Sales where Date={x}").FirstOrDefaultAsync();

            var sale =await dbContext.Sales.FirstOrDefaultAsync(x=>x.Date.Equals(saleDate));

            return sale;
        }

        public async Task<Sale> GetByIdAsync(int id)
        {
            return await dbContext.Sales.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> GetCount()
        {
            return await dbContext.Sales.CountAsync();
        }
    }
}
