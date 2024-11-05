namespace BedBankReports.API.Models.Dto.Rate
{
    public class CreateRateDto
    {
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public string RoomType { get; set; } = string.Empty;
        public float B2B { get; set; }
        public float WebBeds { get; set; }

        public float OurBestPrice { get; set; }

        public float OtherToPrice { get; set; }

        public DateTime CreatedDate { get; set; }
        public int HotelId { get; set; }
    }
}
