using BedBankReports.API.Models.Domain;

namespace BedBankReports.API.Repositories.Interface
{
    public interface IFileRepository
    {
        public Task<List<FileRecord>> GetAllFiles();
        public Task<FileData> GetById(int id);
        public Task SaveToDB(FileRecord record);
        public Task<FileRecord> SaveToServer(IFormFile myFile);

    }
}
