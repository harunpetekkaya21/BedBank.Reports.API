using BedBankReports.API.Models.Domain;

namespace BedBankReports.API.Repositories.Interface
{
    public interface ISaleRepository
    {
        Task<IEnumerable<Sale>> GetAllAsync();
        

        Task<Sale> GetByIdAsync(int id);
        Task<Sale> GetByDateAsync(DateOnly date);


        Task<int> GetCount();
    }
}
