﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BedBankReports.API.Models.Domain
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
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public  float? DiffEuro { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public float? DiffPercent { get; set; }//Yuzdesı

        public DateTime CreatedDate { get; set; }
        public int HotelId { get; set; }
        public  Hotel?  Hotel { get; set; }
    }
}
