namespace BedBankReports.API.Models.Domain
{
    public class Sale
    {
        public int Id { get; set; }
        //Euro
        public float? FinalCost { get; set; }
        //Euro
        public float? FinalSales { get; set; }
        //Euro
        public float? FinalProfit { get; set; }

        //Yuzde Hesabi
        public float? FinalProfitPercent { get; set; }

        public int? RoomNights { get; set; }
        public int? Paxes { get; set; }
        public int? ReservationCount { get; set; }

        public DateOnly Date { get; set; }

    }
}
