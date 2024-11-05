using BedBankReports.API.Models.Domain;

namespace BedBankReports.API.Repositories.Interface
{
    public interface IHotelRepository
    {
      
        Task<IEnumerable<Hotel>> GetAllAsync(); 

        Task<Hotel> GetByIdAsync(int id);

        Task<Hotel> CreateHotelAsync(Hotel hotel);
        Task<Hotel> GetByNameAsync(string hotelName);
        Task<int> GetCount();
    }
}
