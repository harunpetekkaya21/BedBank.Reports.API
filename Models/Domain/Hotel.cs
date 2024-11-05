namespace BedBankReports.API.Models.Domain
{
    public class Hotel
    {
        public Hotel()
        {
            Rates = new HashSet<Rate>();
        }
        public int Id { get; set; }
       
        public string HotelName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        public ICollection<Rate> Rates { get; set; }
    }
}
