using BedBankReports.API.Data;
using BedBankReports.API.Models.Domain;
using BedBankReports.API.Models.Dto.Rate;
using BedBankReports.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BedBankReports.API.Repositories.Implementation
{
    public class RateRepository : IRateRepository
    {

        private readonly ApplicationDbContext dbContext;

        public RateRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public async Task<IEnumerable<Rate>> GetAllAsync()
        {
            return await dbContext.Rates.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Rate>> GetByDatesAsync(DateOnly startDate, DateOnly endDate)
        {
            var _starDate= new DateOnly(startDate.Year, startDate.Month, startDate.Day);
            var _endDate =new DateOnly(endDate.Year, endDate.Month, endDate.Day);

            //var rate = await dbContext.Database.SqlQuery<Rate>($"select * from Rates where StartDate={_starDate} AND EndDate={_endDate}").FirstOrDefaultAsync();
            //return rate;

            var result = await dbContext.Rates.Where(x => x.StartDate.Equals(_starDate) && x.EndDate.Equals(_endDate)).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Rate>> GetListByHotelIdAsync(int id)
        {
          return  await dbContext.Rates.Where(x=>x.HotelId == id).ToListAsync();
            
        }

        public async Task<Rate> GetByIdAsync(int id)
        {
            return await dbContext.Rates.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> GetCount()
        {
            return await dbContext.Rates.CountAsync();
        }

        public async Task<IEnumerable<Rate>> GetByHotelAndDates(int hotelId, DateOnly startDate, DateOnly endDate)
        {
          var result= await dbContext.Rates.Where(x=>x.HotelId==hotelId && x.StartDate.Equals(startDate) && x.EndDate.Equals(endDate)).ToListAsync();

            return result;
        }

        public async Task<CreateRateDto> CreateRateAsync(CreateRateDto rate)
        {
            await dbContext.Rates.AddAsync(new Rate
            {
                B2B=rate.B2B,
                OtherToPrice=rate.OtherToPrice,
                OurBestPrice=rate.OurBestPrice,
                RoomType=rate.RoomType,
               StartDate=rate.StartDate,
               EndDate=rate.EndDate,
               CreatedDate=rate.CreatedDate,
               WebBeds=rate.WebBeds,
               HotelId=rate.HotelId,
               DiffEuro=1.2f,
               DiffPercent=1.2f
              

            });
            await dbContext.SaveChangesAsync();
            return rate;
        }
    }
}
