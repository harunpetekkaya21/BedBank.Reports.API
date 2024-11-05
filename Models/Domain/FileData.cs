namespace BedBankReports.API.Models.Domain
{
    public class FileData
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? FileExtension { get; set; }
        public string? MimeType { get; set; }
        public string? FilePath { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
