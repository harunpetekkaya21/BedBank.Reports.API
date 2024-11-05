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

        public async Task<Rate> CreateRateAsync(CreateRateDto crateRateDto)
        {
            Rate rate=new Rate();
            rate.CreatedDate = crateRateDto.CreatedDate;
            rate.EndDate = crateRateDto.EndDate;
            rate.StartDate = crateRateDto.StartDate;
            rate.B2B=crateRateDto.B2B;
            rate.WebBeds = crateRateDto.WebBeds;
            rate.OurBestPrice=crateRateDto.OurBestPrice;
            rate.OtherToPrice=crateRateDto.OtherToPrice;
            rate.HotelId=crateRateDto.HotelId;
            rate.RoomType = crateRateDto.RoomType;
           
            await dbContext.Rates.AddAsync(rate);
            await dbContext.SaveChangesAsync();
            return rate;
        }

        public async Task<DateTime> GetLastDateTime()
        {
            var result= await dbContext.Rates.OrderByDescending(x=>x.CreatedDate).FirstOrDefaultAsync();
            return result.CreatedDate;
        }

        public async Task<IEnumerable<ListRateDatesDto>> GetListRateDatesByHotelAsync(int id)
        {
           return await dbContext.Rates.Where(x=>x.HotelId==id).Select(x => new ListRateDatesDto
            {
                Id = x.Id,
                Date = x.StartDate.ToString() + "|" + x.EndDate.ToString(),
            }).ToListAsync();
        }

        public async Task<IEnumerable<ListRateRoomsDto>> GetRoomsByHotelAndDates(int hotelId, DateOnly startDate, DateOnly endDate)
        {
           var result = await dbContext.Rates.Where(x=>x.HotelId==hotelId && x.StartDate==startDate && x.EndDate==endDate).Select(x=>new ListRateRoomsDto { Id = x.Id,RoomType=x.RoomType }).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<ListRatesByRoomHotelDateDto>> GetRatesByRoomAndHotelAndDates(int hotelId, DateOnly startDate, DateOnly endDate, string roomType)
        {
            var result = await dbContext.Rates.Where(x => x.HotelId == hotelId && x.StartDate == startDate && x.EndDate == endDate && x.RoomType==roomType).Select(x => new ListRatesByRoomHotelDateDto 
            { 
                B2B=x.B2B,
                RoomType=x.RoomType,
                DiffEuro=x.DiffEuro,
                DiffPercent=x.DiffPercent,
                OtherToPrice=x.OtherToPrice,
                OurBestPrice=x.OurBestPrice,
                WebBeds=x.WebBeds
            
            }).ToListAsync();

            return result;
        }
    }
}
