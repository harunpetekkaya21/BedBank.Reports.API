namespace BedBankReports.API.Models.Domain
{
    public class FileModel
    {
        public IFormFile? MyFile { get; set; }
        
        public string? Description { get; set; }
    }
}
