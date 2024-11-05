using BedBankReports.API.Models.Domain;
using BedBankReports.API.Models.Dto.Rate;

namespace BedBankReports.API.Repositories.Interface
{
    public interface IRateRepository
    {
        Task<IEnumerable<Rate>> GetAllAsync();


        Task<Rate> GetByIdAsync(int id);
        Task<CreateRateDto> CreateRateAsync(CreateRateDto rate);
        Task<IEnumerable<Rate>> GetListByHotelIdAsync(int id);
        Task<IEnumerable<Rate>> GetByDatesAsync(DateOnly startDate,DateOnly endDate);
        Task<IEnumerable<Rate>> GetByHotelAndDates(int hotelId, DateOnly startDate, DateOnly endDate);

     Task<int> GetCount();
    }
}
