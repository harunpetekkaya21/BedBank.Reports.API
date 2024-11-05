namespace BedBankReports.API.Models.Domain
{
    public class FileRecord
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? FileFormat { get; set; }
        public string? FilePath { get; set; }
        public string? ContentType { get; set; }
       
        public string? Description { get; set; }
    }
}
