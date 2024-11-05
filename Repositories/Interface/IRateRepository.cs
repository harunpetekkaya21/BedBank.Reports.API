using BedBankReports.API.Models.Domain;
using BedBankReports.API.Models.Dto.Rate;

namespace BedBankReports.API.Repositories.Interface
{
    public interface IRateRepository
    {
        Task<IEnumerable<Rate>> GetAllAsync();


        Task<Rate> GetByIdAsync(int id);
        Task<Rate> CreateRateAsync(CreateRateDto crateRateDto);
        Task<IEnumerable<Rate>> GetListByHotelIdAsync(int id);
        Task<IEnumerable<ListRateDatesDto>> GetListRateDatesByHotelAsync(int id);
        Task<IEnumerable<ListRateRoomsDto>> GetRoomsByHotelAndDates(int hotelId, DateOnly startDate, DateOnly endDate);
        Task<IEnumerable<ListRatesByRoomHotelDateDto>> GetRatesByRoomAndHotelAndDates(int hotelId, DateOnly startDate, DateOnly endDate,string  roomType);
        Task<IEnumerable<Rate>> GetByDatesAsync(DateOnly startDate,DateOnly endDate);
        Task<IEnumerable<Rate>> GetByHotelAndDates(int hotelId, DateOnly startDate, DateOnly endDate);

        Task<DateTime> GetLastDateTime();

     Task<int> GetCount();
    }
}
