using BedBankReports.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BedBankReports.API.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(

                new Hotel
                {
                    Id = 1,

                    HotelName = "GRAND PARK LARA",
                    CreatedDate = DateTime.UtcNow,

                },
                new Hotel
                {
                    Id = 2,

                    HotelName = "CONCORDIA CELES HOTEL",
                    CreatedDate = DateTime.UtcNow,

                },
                new Hotel
                 {
                     Id = 3,

                     HotelName = "ROYAL WINGS HOTEL",
                    CreatedDate = DateTime.UtcNow,

                },
                new Hotel
                 {
                     Id = 4,

                     HotelName = "HORUS PARADISE LUXURY RESORT",
                    CreatedDate = DateTime.UtcNow,

                },
                new Hotel
                  {
                      Id = 5,

                      HotelName = "ROYAL SEGINUS",
                    CreatedDate = DateTime.UtcNow,

                },
                new Hotel
                  {
                      Id = 6,

                      HotelName = "ALARCHA HOTELS",
                    CreatedDate = DateTime.UtcNow,

                },
                new Hotel
                   {
                       Id = 7,

                       HotelName = "NOXINN DELUXE HOTEL",
                    CreatedDate = DateTime.UtcNow,

                },
                new Hotel
                    {
                        Id = 8,

                        HotelName = "ADALYA ELITE LARA",
                    CreatedDate = DateTime.UtcNow,

                },
                new Hotel
                     {
                         Id = 9,

                         HotelName = "ALAN XAFIRA DELUXE RESORT",
                    CreatedDate = DateTime.UtcNow,

                },
                new Hotel
                      {
                          Id = 10,

                          HotelName = "SEVEN SEAS GRAVEL SELECT",
                    CreatedDate = DateTime.UtcNow,

                }
            );

            modelBuilder.Entity<Rate>().HasData(

                //"GRAND PARK LARA 1
                //new Rate
                //{
                //    //"GRAND PARK LARA 1
                //    Id = 1,
                //    HotelId = 1,
                //    StartDate = new DateOnly(2025, 4, 21),
                //    EndDate = new DateOnly(2025, 4, 28),
                //    RoomType = "Std Room",
                //    B2B = 380.0f,
                //    WebBeds = 647.84f,
                //    OurBestPrice = 380.0f,
                //    OtherToPrice = 604.97f,
                //    CreatedDate=DateTime.UtcNow,

                //}
                //new Rate
                //{
                //    //"GRAND PARK LARA 1
                //    Id = 2,
                //    HotelId = 1,
                //    StartDate = new DateOnly(2025, 6, 16),
                //    EndDate = new DateOnly(2025, 6, 23),
                //    RoomType = "Std Room",
                //    B2B = 980.0f,
                //    WebBeds = 1121.26f,
                //    OurBestPrice = 980.0f,
                //    OtherToPrice = 1043.34f,
                //    DiffEuro = 63.0f,
                //    DiffPercent = 6.50f

                //},
                //new Rate
                //{
                //    //"GRAND PARK LARA 1
                //    Id = 3,
                //    HotelId = 1,
                //    StartDate = new DateOnly(2025, 8, 4),
                //    EndDate = new DateOnly(2025, 8, 11),
                //    RoomType = "Std Room",
                //    B2B = 1080.0f,
                //    WebBeds = 1370.40f,
                //    OurBestPrice = 1080.0f,
                //    OtherToPrice = 1274.10f,
                //    DiffEuro = 194.0f,
                //    DiffPercent = 18.0f

                //},
                //new Rate
                //{
                //    //"GRAND PARK LARA 1
                //    Id = 4,
                //    HotelId = 1,
                //    StartDate = new DateOnly(2025, 9, 22),
                //    EndDate = new DateOnly(2025, 9, 29),
                //    RoomType = "Std Room",
                //    B2B = 1180.0f,
                //    WebBeds = 1121.30f,
                //    OurBestPrice = 1121.30f,
                //    OtherToPrice = 1043.30f,
                //    DiffEuro = -78.0f,
                //    DiffPercent = -6.90f

                //},
                ////"CONCORDIA CELES HOTEL 2
                //new Rate
                //{
                //    //"CONCORDIA CELES HOTEL 2
                //    Id = 5,
                //    HotelId = 2,
                //    StartDate = new DateOnly(2025, 4, 21),
                //    EndDate = new DateOnly(2025, 4, 28),
                //    RoomType = "Std Room",
                //    B2B = 480.0f,
                //    WebBeds = 616.10f,
                //    OurBestPrice = 480.0f,
                //    OtherToPrice = 545.90f,
                //    DiffEuro = 66.0f,
                //    DiffPercent = 13.70f

                //},
                //new Rate
                //{
                //    //"CONCORDIA CELES HOTEL 2
                //    Id = 6,
                //    HotelId = 2,
                //    StartDate = new DateOnly(2025, 6, 16),
                //    EndDate = new DateOnly(2025, 6, 23),
                //    RoomType = "Std Room",
                //    B2B = 980.0f,
                //    WebBeds = 898.90f,
                //    OurBestPrice = 898.90f,
                //    OtherToPrice = 793.10f,
                //    DiffEuro = -106.0f,
                //    DiffPercent = -11.80f

                //},
                //new Rate
                //{
                //    //"CONCORDIA CELES HOTEL 2
                //    Id = 7,
                //    HotelId = 2,
                //    StartDate = new DateOnly(2025, 6, 16),
                //    EndDate = new DateOnly(2025, 6, 23),
                //    RoomType = "Std Room",
                //    B2B = 980.0f,
                //    WebBeds = 898.90f,
                //    OurBestPrice = 898.90f,
                //    OtherToPrice = 793.10f,
                //    DiffEuro = -106.0f,
                //    DiffPercent = -11.80f

                //},
                //new Rate
                //{
                //    //"CONCORDIA CELES HOTEL 2
                //    Id = 8,
                //    HotelId = 2,
                //    StartDate = new DateOnly(2025, 8, 4),
                //    EndDate = new DateOnly(2025, 8, 11),
                //    RoomType = "Std Room",
                //    B2B = 1080.0f,
                //    WebBeds = 1170.40f,
                //    OurBestPrice = 1080.0f,
                //    OtherToPrice = 1032.50f,
                //    DiffEuro = -47.0f,
                //    DiffPercent = -4.40f

                //},
                //new Rate
                //{
                //    //"CONCORDIA CELES HOTEL 2
                //    Id = 9,
                //    HotelId = 2,
                //    StartDate = new DateOnly(2025, 9, 22),
                //    EndDate = new DateOnly(2025, 9, 29),
                //    RoomType = "Std Room",
                //    B2B = 780.0f,
                //    WebBeds = 923.20f,
                //    OurBestPrice = 780.0f,
                //    OtherToPrice = 816.20f,
                //    DiffEuro = 36.0f,
                //    DiffPercent = 4.60f

                //},
                ////ROYAL WINGS HOTEL
                //new Rate
                //{
                //    //"ROYAL WINGS HOTEL 3 
                //    Id = 10,
                //    HotelId = 3,
                //    StartDate = new DateOnly(2025, 4, 21),
                //    EndDate = new DateOnly(2025, 4, 28),
                //    RoomType = "Land View",
                //    B2B = 2080.0f,
                //    WebBeds = 1131.30f,
                //    OurBestPrice = 1131.30f,
                //    OtherToPrice = 1151.50f,
                //    DiffEuro = 20.0f,
                //    DiffPercent = 1.80f

                //},
                //new Rate
                //{
                //    //"ROYAL WINGS HOTEL 3 
                //    Id = 11,
                //    HotelId = 3,
                //    StartDate = new DateOnly(2025, 6, 16),
                //    EndDate = new DateOnly(2025, 6, 23),
                //    RoomType = "Land View",
                //    B2B = 2180.0f,
                //    WebBeds = 1860.10f,
                //    OurBestPrice = 1860.10f,
                //    OtherToPrice = 1873.0f,
                //    DiffEuro = 13.0f,
                //    DiffPercent = 0.70f

                //},
                //new Rate
                //{
                //    //"ROYAL WINGS HOTEL 3 
                //    Id = 12,
                //    HotelId = 3,
                //    StartDate = new DateOnly(2025, 8, 4),
                //    EndDate = new DateOnly(2025, 8, 11),
                //    RoomType = "Land View",
                //    B2B = 2280.0f,
                //    WebBeds = 2276.10f,
                //    OurBestPrice = 2276.10f,
                //    OtherToPrice = 2287.10f,
                //    DiffEuro = 11.0f,
                //    DiffPercent = 0.50f

                //},
                //new Rate
                //{
                //    //"ROYAL WINGS HOTEL 3 
                //    Id = 13,
                //    HotelId = 3,
                //    StartDate = new DateOnly(2025, 9, 22),
                //    EndDate = new DateOnly(2025, 9, 29),
                //    RoomType = "Land View",
                //    B2B = 2380.0f,
                //    WebBeds = 1797.40f,
                //    OurBestPrice = 1797.40f,
                //    OtherToPrice = 1811.20f,
                //    DiffEuro = 14.0f,
                //    DiffPercent = 0.80f

                //},

                // //HORUS PARADISE LUXURY RESORT
                //new Rate
                // {
                //     //"HORUS PARADISE LUXURY RESORT 4 
                //     Id = 14,
                //     HotelId = 4,
                //     StartDate = new DateOnly(2025, 4, 21),
                //     EndDate = new DateOnly(2025, 4, 28),
                //     RoomType = "Garden Room",
                //     B2B = 400.0f,
                //     WebBeds = 563.60f,
                //     OurBestPrice = 400.0f,
                //     OtherToPrice = 590.40f,
                //     DiffEuro = 190.0f,
                //     DiffPercent = 47.60f

                // },
                //new Rate
                //  {
                //      //"HORUS PARADISE LUXURY RESORT 4 
                //      Id = 15,
                //      HotelId = 4,
                //      StartDate = new DateOnly(2025, 6, 16),
                //      EndDate = new DateOnly(2025, 6, 23),
                //      RoomType = "Garden Room",
                //      B2B = 500.0f,
                //      WebBeds = 780.40f,
                //      OurBestPrice = 500.0f,
                //      OtherToPrice = 815.70f,
                //      DiffEuro = 316.0f,
                //      DiffPercent = 63.10f

                //  },
                //new Rate
                //   {
                //       //"HORUS PARADISE LUXURY RESORT 4 
                //       Id = 16,
                //       HotelId = 4,
                //       StartDate = new DateOnly(2025, 8, 4),
                //       EndDate = new DateOnly(2025, 8, 11),
                //       RoomType = "Garden Room",
                //       B2B = 600.0f,
                //       WebBeds = 1010.70f,
                //       OurBestPrice = 600.0f,
                //       OtherToPrice = 1062.40f,
                //       DiffEuro = 462.0f,
                //       DiffPercent = 77.10f

                //   },
                //new Rate
                //    {
                //        //"HORUS PARADISE LUXURY RESORT 4 
                //        Id = 17,
                //        HotelId = 4,
                //        StartDate = new DateOnly(2025, 9, 22),
                //        EndDate = new DateOnly(2025, 9, 29),
                //        RoomType = "Garden Room",
                //        B2B = 700.0f,
                //        WebBeds = 890.20f,
                //        OurBestPrice = 700.0f,
                //        OtherToPrice = 930.30f,
                //        DiffEuro = 230.0f,
                //        DiffPercent = 32.90f

                //    },

                ////ROYAL SEGINUS
                //new Rate
                //     {
                //         //"HORUS PARADISE LUXURY RESORT 5
                //         Id = 18,
                //         HotelId = 5,
                //         StartDate = new DateOnly(2025, 4, 21),
                //         EndDate = new DateOnly(2025, 9, 28),
                //         RoomType = "Family Land V",
                //         B2B = 1500.0f,
                //         WebBeds = 2175.60f,
                //         OurBestPrice = 1500.0f,
                //         OtherToPrice = 2440.40f,
                //         DiffEuro = 744.0f,
                //         DiffPercent = 49.60f

                //     },
                //new Rate
                //       {
                //           //"HORUS PARADISE LUXURY RESORT 5
                //           Id = 19,
                //           HotelId = 5,
                //           StartDate = new DateOnly(2025, 6, 16),
                //           EndDate = new DateOnly(2025, 6, 23),
                //           RoomType = "Family Land V",
                //           B2B = 1600.0f,
                //           WebBeds = 3147.70f,
                //           OurBestPrice = 1600.0f,
                //           OtherToPrice = 3243.20f,
                //           DiffEuro = 1643.0f,
                //           DiffPercent = 102.70f

                //       },
                //new Rate
                //        {
                //            //"HORUS PARADISE LUXURY RESORT 5
                //            Id = 20,
                //            HotelId = 5,
                //            StartDate = new DateOnly(2025, 8, 4),
                //            EndDate = new DateOnly(2025, 8, 11),
                //            RoomType = "Family Land V",
                //            B2B = 1700.0f,
                //            WebBeds = 3597.40f,
                //            OurBestPrice = 1700.0f,
                //            OtherToPrice = 3705.70f,
                //            DiffEuro = 2006.0f,
                //            DiffPercent = 118.0f

                //        },
                //new Rate
                //        {
                //            //"HORUS PARADISE LUXURY RESORT 5
                //            Id = 21,
                //            HotelId = 5,
                //            StartDate = new DateOnly(2025, 9, 22),
                //            EndDate = new DateOnly(2025, 9, 29),
                //            RoomType = "Family Land V",
                //            B2B = 1800.0f,
                //            WebBeds = 2869.30f,
                //            OurBestPrice = 1800.0f,
                //            OtherToPrice = 2971.80f,
                //            DiffEuro = 1172.0f,
                //            DiffPercent = 65.10f

                //        },

                ////ALARCHA HOTELS

                //new Rate
                //        {
                //            //"ALARCHA HOTELS 6
                //            Id = 22,
                //            HotelId = 6,
                //            StartDate = new DateOnly(2025, 6, 16),
                //            EndDate = new DateOnly(2025, 6, 23),
                //            RoomType = "Land View",
                //            B2B = 600.0f,
                //            WebBeds = 832.30f,
                //            OurBestPrice = 600.0f,
                //            OtherToPrice = 870.20f,
                //            DiffEuro = 270.0f,
                //            DiffPercent = 45.0f

                //        },
                //new Rate
                //          {
                //              //"ALARCHA HOTELS 6
                //              Id = 23,
                //              HotelId = 6,
                //              StartDate = new DateOnly(2025, 8, 4),
                //              EndDate = new DateOnly(2025, 8, 11),
                //              RoomType = "Land View",
                //              B2B = 700.0f,
                //              WebBeds = 971.80f,
                //              OurBestPrice = 700.0f,
                //              OtherToPrice = 1014.40f,
                //              DiffEuro = 314.0f,
                //              DiffPercent = 44.90f

                //          },
                //new Rate
                //            {
                //                //"ALARCHA HOTELS 6
                //                Id = 24,
                //                HotelId = 6,
                //                StartDate = new DateOnly(2025, 9, 22),
                //                EndDate = new DateOnly(2025, 9, 29),
                //                RoomType = "Land View",
                //                B2B = 800.0f,
                //                WebBeds = 866.60f,
                //                OurBestPrice = 800.0f,
                //                OtherToPrice = 906.20f,
                //                DiffEuro = 106.0f,
                //                DiffPercent = 13.30f

                //            },
                ////NOXINN DELUXE HOTEL

                //new Rate
                //             {
                //                 //"NOXINN DELUXE HOTEL 7
                //                 Id = 25,
                //                 HotelId = 7,
                //                 StartDate = new DateOnly(2025, 6, 16),
                //                 EndDate = new DateOnly(2025, 6, 23),
                //                 RoomType = "Std Room",
                //                 B2B = 900.0f,
                //                 WebBeds = 766.90f,
                //                 OurBestPrice = 766.90f,
                //                 OtherToPrice = 798.60f,
                //                 DiffEuro = 32.0f,
                //                 DiffPercent = 4.10f

                //             },
                //new Rate
                //             {
                //                 //"NOXINN DELUXE HOTEL 7
                //                 Id = 26,
                //                 HotelId = 7,
                //                 StartDate = new DateOnly(2025, 8, 4),
                //                 EndDate = new DateOnly(2025, 8, 11),
                //                 RoomType = "Std Room",
                //                 B2B = 1000.0f,
                //                 WebBeds = 998.0f,
                //                 OurBestPrice = 998.0f,
                //                 OtherToPrice = 1037.60f,
                //                 DiffEuro = 40.0f,
                //                 DiffPercent = 4.0f

                //             },
                //new Rate
                //              {
                //                  //"NOXINN DELUXE HOTEL 7
                //                  Id = 27,
                //                  HotelId = 7,
                //                  StartDate = new DateOnly(2025, 9, 22),
                //                  EndDate = new DateOnly(2025, 9, 29),
                //                  RoomType = "Std Room",
                //                  B2B = 1100.0f,
                //                  WebBeds = 511.20f,
                //                  OurBestPrice = 511.20f,
                //                  OtherToPrice = 537.0f,
                //                  DiffEuro = 26.0f,
                //                  DiffPercent = 5.0f

                //              },

                ////ADALYA ELITE LARA
                //new Rate
                //               {
                //                   //" ADALYA ELITE LARA 
                //                   Id = 28,
                //                   HotelId = 8,
                //                   StartDate = new DateOnly(2025, 4, 21),
                //                   EndDate = new DateOnly(2025, 4, 28),
                //                   RoomType = "no-room-type",
                //                   B2B = 900.0f,
                //                   WebBeds = 766.90f,
                //                   OurBestPrice = 766.90f,
                //                   OtherToPrice = 900.0f,
                //                   DiffEuro = 113.0f,
                //                   DiffPercent = 17.40f

                //               },
                //new Rate
                //                {
                //                    //" ADALYA ELITE LARA 
                //                    Id = 29,
                //                    HotelId = 8,
                //                    StartDate = new DateOnly(2025, 6, 16),
                //                    EndDate = new DateOnly(2025, 6, 23),
                //                    RoomType = "no-room-type",
                //                    B2B = 1000.0f,
                //                    WebBeds = 998.0f,
                //                    OurBestPrice = 998.0f,
                //                    OtherToPrice = 1000.0f,
                //                    DiffEuro = 2.0f,
                //                    DiffPercent = 0.20f

                //                },
                //new Rate
                //                  {
                //                      //" ADALYA ELITE LARA 
                //                      Id = 30,
                //                      HotelId = 8,
                //                      StartDate = new DateOnly(2025, 8, 4),
                //                      EndDate = new DateOnly(2025, 8, 11),
                //                      RoomType = "no-room-type",
                //                      B2B = 1100.0f,
                //                      WebBeds = 511.20f,
                //                      OurBestPrice = 511.20f,
                //                      OtherToPrice = 1100.0f,
                //                      DiffEuro = 589.0f,
                //                      DiffPercent = 115.20f

                //                  },
                //new Rate
                //                  {
                //                      //" ADALYA ELITE LARA 
                //                      Id = 31,
                //                      HotelId = 8,
                //                      StartDate = new DateOnly(2025, 9, 22),
                //                      EndDate = new DateOnly(2025, 9, 29),
                //                      RoomType = "no-room-type",
                //                      B2B = 1100.0f,
                //                      WebBeds = 511.20f,
                //                      OurBestPrice = 511.20f,
                //                      OtherToPrice = 1100.0f,
                //                      DiffEuro = 589.0f,
                //                      DiffPercent = 115.20f

                //                  },

                ////" ALAN XAFIRA DELUXE RESORT

                //new Rate
                //                   {
                //                       //" ALAN XAFIRA DELUXE RESORT
                //                       Id = 32,
                //                       HotelId = 9,
                //                       StartDate = new DateOnly(2025, 4, 21),
                //                       EndDate = new DateOnly(2025, 4, 28),
                //                       RoomType = "no-room-type",
                //                       B2B = 900.0f,
                //                       WebBeds = 766.90f,
                //                       OurBestPrice = 766.90f,
                //                       OtherToPrice = 900.0f,
                //                       DiffEuro = 113.0f,
                //                       DiffPercent = 17.40f

                //                   },
                //new Rate
                //                    {
                //                        //" ALAN XAFIRA DELUXE RESORT
                //                        Id = 33,
                //                        HotelId = 9,
                //                        StartDate = new DateOnly(2025, 6, 16),
                //                        EndDate = new DateOnly(2025, 6, 23),
                //                        RoomType = "no-room-type",
                //                        B2B = 100.0f,
                //                        WebBeds = 998.0f,
                //                        OurBestPrice = 998.0f,
                //                        OtherToPrice = 1000.0f,
                //                        DiffEuro = 2.0f,
                //                        DiffPercent = 0.20f

                //                    },
                //new Rate
                //                      {
                //                          //" ALAN XAFIRA DELUXE RESORT
                //                          Id = 34,
                //                          HotelId = 9,
                //                          StartDate = new DateOnly(2025, 8, 4),
                //                          EndDate = new DateOnly(2025, 8, 11),
                //                          RoomType = "no-room-type",
                //                          B2B = 1100.0f,
                //                          WebBeds = 511.20f,
                //                          OurBestPrice = 511.20f,
                //                          OtherToPrice = 1100.0f,
                //                          DiffEuro = 589.0f,
                //                          DiffPercent = 115.20f

                //                      },
                //new Rate
                //                        {
                //                            //" ALAN XAFIRA DELUXE RESORT
                //                            Id = 35,
                //                            HotelId = 9,
                //                            StartDate = new DateOnly(2025, 9, 22),
                //                            EndDate = new DateOnly(2025, 9, 9),
                //                            RoomType = "no-room-type",
                //                            B2B = 1100.0f,
                //                            WebBeds = 511.20f,
                //                            OurBestPrice = 511.20f,
                //                            OtherToPrice = 1100.0f,
                //                            DiffEuro = 589.0f,
                //                            DiffPercent = 115.20f

                //                        },

                ////SEVEN SEAS GRAVEL SELECT

                //new Rate
                //                        {
                //                            //" SEVEN SEAS GRAVEL SELECT
                //                            Id = 36,
                //                            HotelId = 10,
                //                            StartDate = new DateOnly(2025, 4, 21),
                //                            EndDate = new DateOnly(2025, 4, 28),
                //                            RoomType = "no-room-type",
                //                            B2B = 900.0f,
                //                            WebBeds = 766.90f,
                //                            OurBestPrice = 766.90f,
                //                            OtherToPrice = 900.0f,
                //                            DiffEuro = 133.0f,
                //                            DiffPercent = 17.40f

                //                        },
                //new Rate
                //                         {
                //                             //" SEVEN SEAS GRAVEL SELECT
                //                             Id = 37,
                //                             HotelId = 10,
                //                             StartDate = new DateOnly(2025, 6, 16),
                //                             EndDate = new DateOnly(2025, 6, 23),
                //                             RoomType = "no-room-type",
                //                             B2B = 1000.0f,
                //                             WebBeds = 998.00f,
                //                             OurBestPrice = 998.00f,
                //                             OtherToPrice = 1000.0f,
                //                             DiffEuro = 2.0f,
                //                             DiffPercent = 0.20f

                //                         },
                //new Rate
                //                          {
                //                              //" SEVEN SEAS GRAVEL SELECT
                //                              Id = 38,
                //                              HotelId = 10,
                //                              StartDate = new DateOnly(2025, 8, 4),
                //                              EndDate = new DateOnly(2025, 8, 11),
                //                              RoomType = "no-room-type",
                //                              B2B = 1100.0f,
                //                              WebBeds = 511.20f,
                //                              OurBestPrice = 511.20f,
                //                              OtherToPrice = 1100.0f,
                //                              DiffEuro = 589.0f,
                //                              DiffPercent = 115.20f

                //                          },
                //new Rate
                //                            {
                //                                //" SEVEN SEAS GRAVEL SELECT
                //                                Id = 39,
                //                                HotelId = 10,
                //                                StartDate = new DateOnly(2025, 8, 4),
                //                                EndDate = new DateOnly(2025, 8, 11),
                //                                RoomType = "no-room-type",
                //                                B2B = 1100.0f,
                //                                WebBeds = 511.20f,
                //                                OurBestPrice = 511.20f,
                //                                OtherToPrice = 1100.0f,
                //                                DiffEuro = 589.0f,
                //                                DiffPercent = 115.20f

                //                            }

                );


            //Sales Report

            modelBuilder.Entity<Sale>().HasData(

                new Sale
                {
                    Id = 1,
                    FinalCost = 1500.0f,
                    FinalSales = 2500.0f,
                    FinalProfit = 1000.0f,
                    FinalProfitPercent = 66.67f,
                    RoomNights = 50,
                    Paxes = 50,
                    ReservationCount = 5,
                    Date = new DateOnly(2024, 10, 1),
                    CreatedDate = DateTime.UtcNow


                },
                new Sale
                {
                    Id = 2,
                    FinalCost = 2000.0f,
                    FinalSales = 2500.0f,
                    FinalProfit = 500.0f,
                    FinalProfitPercent = 25.0f,
                    RoomNights = 60,
                    Paxes = 60,
                    ReservationCount = 6,
                    Date = new DateOnly(2024, 10, 2),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 3,
                    FinalCost = 1000.0f,
                    FinalSales = 1500.0f,
                    FinalProfit = 150.0f,
                    FinalProfitPercent = 15.0f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 3),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 4,
                    FinalCost = 4500.0f,
                    FinalSales = 4900.0f,
                    FinalProfit = 400.0f,
                    FinalProfitPercent = 8.99f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 4),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 5,
                    FinalCost = 985.0f,
                    FinalSales = 1050.0f,
                    FinalProfit = 65.0f,
                    FinalProfitPercent = 6.60f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 5),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 6,
                    FinalCost = 900.0f,
                    FinalSales = 1500.0f,
                    FinalProfit = 600.0f,
                    FinalProfitPercent = 66.67f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 6),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 7,
                    FinalCost = 900.0f,
                    FinalSales = 1250.0f,
                    FinalProfit = 250.0f,
                    FinalProfitPercent = 38.89f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 7),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 8,
                    FinalCost = 900.0f,
                    FinalSales = 750.0f,
                    FinalProfit = -150.0f,
                    FinalProfitPercent = -16.67f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 8),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 9,
                    FinalCost = 6800.0f,
                    FinalSales = 7900.0f,
                    FinalProfit = 1100.0f,
                    FinalProfitPercent = 16.18f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 9),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 10,
                    FinalCost = 4900.0f,
                    FinalSales = 5980.0f,
                    FinalProfit = 1080.0f,
                    FinalProfitPercent = 22.04f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 10),
                    CreatedDate = DateTime.UtcNow

                },

                new Sale
                {
                    Id = 11,
                    FinalCost = 9600.0f,
                    FinalSales = 10900.0f,
                    FinalProfit = 1300.0f,
                    FinalProfitPercent = 13.54f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 11),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 12,
                    FinalCost = 1500.0f,
                    FinalSales = 2900.0f,
                    FinalProfit = 1400.0f,
                    FinalProfitPercent = 93.33f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 12),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 13,
                    FinalCost = 1900.0f,
                    FinalSales = 2740.0f,
                    FinalProfit = 840.0f,
                    FinalProfitPercent = 44.21f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 13),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 14,
                    FinalCost = 3250.0f,
                    FinalSales = 3480.0f,
                    FinalProfit = 230.0f,
                    FinalProfitPercent = 7.08f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 14),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 15,
                    FinalCost = 4900.0f,
                    FinalSales = 5350.0f,
                    FinalProfit = 450.0f,
                    FinalProfitPercent = 9.18f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 15),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 16,
                    FinalCost = 1500.0f,
                    FinalSales = 1960.0f,
                    FinalProfit = 460.0f,
                    FinalProfitPercent = 30.67f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 16),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 17,
                    FinalCost = 1400.0f,
                    FinalSales = 1490.0f,
                    FinalProfit = 90.0f,
                    FinalProfitPercent = 6.43f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 17),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 18,
                    FinalCost = 3900.0f,
                    FinalSales = 4150.0f,
                    FinalProfit = 250.0f,
                    FinalProfitPercent = 6.41f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 18),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 19,
                    FinalCost = 4900.0f,
                    FinalSales = 5040.0f,
                    FinalProfit = 140.0f,
                    FinalProfitPercent = 2.86f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 19),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 20,
                    FinalCost = 1600.0f,
                    FinalSales = 1500.0f,
                    FinalProfit = -100.0f,
                    FinalProfitPercent = -6.25f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 20),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 21,
                    FinalCost = 1460.0f,
                    FinalSales = 1390.0f,
                    FinalProfit = -70.0f,
                    FinalProfitPercent = -4.79f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 21),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 22,
                    FinalCost = 1500.0f,
                    FinalSales = 1790.0f,
                    FinalProfit = 290.0f,
                    FinalProfitPercent = 19.33f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 22),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 23,
                    FinalCost = 3500.0f,
                    FinalSales = 3650.0f,
                    FinalProfit = 150.0f,
                    FinalProfitPercent = 4.29f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 23),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 24,
                    FinalCost = 1100.0f,
                    FinalSales = 1249.0f,
                    FinalProfit = 149.0f,
                    FinalProfitPercent = 13.55f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 24),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 25,
                    FinalCost = 2600.0f,
                    FinalSales = 2790.0f,
                    FinalProfit = 190.0f,
                    FinalProfitPercent = 7.31f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 25),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 26,
                    FinalCost = 2250.0f,
                    FinalSales = 2735.0f,
                    FinalProfit = 485.0f,
                    FinalProfitPercent = 21.56f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 26),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 27,
                    FinalCost = 5600.0f,
                    FinalSales = 5980.0f,
                    FinalProfit = 380.0f,
                    FinalProfitPercent = 6.79f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 27),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 28,
                    FinalCost = 5100.0f,
                    FinalSales = 5325.0f,
                    FinalProfit = 225.0f,
                    FinalProfitPercent = 4.41f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 28),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 29,
                    FinalCost = 3100.0f,
                    FinalSales = 3950.0f,
                    FinalProfit = 850.0f,
                    FinalProfitPercent = 27.42f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 29),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 30,
                    FinalCost = 3500.0f,
                    FinalSales = 3750.0f,
                    FinalProfit = 250.0f,
                    FinalProfitPercent = 7.17f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 30),
                    CreatedDate = DateTime.UtcNow

                },
                new Sale
                {
                    Id = 31,
                    FinalCost = 4550.0f,
                    FinalSales = 4970.0f,
                    FinalProfit = 420.0f,
                    FinalProfitPercent = 9.23f,
                    RoomNights = -1,
                    Paxes = -1,
                    ReservationCount = -1,
                    Date = new DateOnly(2024, 10, 31),
                    CreatedDate = DateTime.UtcNow

                }


                );

        }
    }
}
