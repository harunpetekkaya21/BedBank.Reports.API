namespace BedBankReports.API.Models.Dto.Rate
{
    public class ListRatesByRoomHotelDateDto
    {
        public string RoomType { get; set; } = string.Empty;
        public float B2B { get; set; }
        public float WebBeds { get; set; }
        public float OurBestPrice { get; set; }
        public float OtherToPrice { get; set; }
        public float DiffEuro { get; set; }
        public float DiffPercent { get; set; }//Yuzdesı

    }
}
