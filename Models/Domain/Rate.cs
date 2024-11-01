﻿namespace BedBankReports.API.Models.Domain
{
    public class Rate
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public string RoomType { get; set; } = string.Empty;
        public float B2B { get; set; }
        public float WebBeds { get; set; }
        public float OurBestPrice { get; set; }
        public float OtherToPrice { get; set; }
        public float DiffEuro { get; set; }
        public float DiffPercent { get; set; }//Yuzdesı


        public int HotelId { get; set; }
        public  Hotel?  Hotel { get; set; }
    }
}
