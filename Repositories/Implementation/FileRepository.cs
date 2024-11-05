using BedBankReports.API.Data;
using BedBankReports.API.Models.Domain;
using BedBankReports.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BedBankReports.API.Repositories.Implementation
{
    public class FileRepository : IFileRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly string AppDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        public FileRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<FileRecord>> GetAllFiles()
        {
            return await dbContext.FileDatas.Select(n => new FileRecord
            {
                Id = n.Id,
                ContentType = n.MimeType,
                FileFormat = n.FileExtension,
                FileName = n.FileName,
                FilePath = n.FilePath
            }).ToListAsync();
        }

        public async Task<FileData> GetById(int id)
        {
            return await dbContext.FileDatas.Where(n => n.Id == id).FirstOrDefaultAsync();
        }

        public async Task SaveToDB(FileRecord record)
        {
            if (record == null)
                throw new ArgumentNullException($"{nameof(record)}");

            FileData fileData = new FileData();
            fileData.FilePath = record.FilePath;
            fileData.FileName = record.FileName;
            fileData.FileExtension = record.FileFormat;
            fileData.MimeType = record.ContentType;
            fileData.CreatedDate = DateTime.UtcNow;

            await dbContext.FileDatas.AddAsync(fileData);
            await dbContext.SaveChangesAsync();
        }

        public async Task<FileRecord> SaveToServer(IFormFile myFile)
        {
            List<FileRecord> fileDB = new List<FileRecord>();
            FileRecord file = new FileRecord();
            if (myFile != null)
            {
                if (!Directory.Exists(AppDirectory))
                    Directory.CreateDirectory(AppDirectory);

                var fileName = DateTime.UtcNow.Ticks.ToString()+"-"+myFile.FileName.Replace(" ","-") + Path.GetExtension(myFile.FileName);
                var path = Path.Combine(AppDirectory, fileName);

                file.Id = fileDB.Count() + 1;
                file.FilePath = path;
                file.FileName = fileName;
                file.FileFormat = Path.GetExtension(myFile.FileName);
                file.ContentType = myFile.ContentType;

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await myFile.CopyToAsync(stream);
                }

                return file;
            }
            return file;
        }
    }
}
