using BedBankReports.API.Models.Dto.Hotel;
using BedBankReports.API.Models.Dto.Rate;
using BedBankReports.API.Repositories.Implementation;
using BedBankReports.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BedBankReports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatesController : ControllerBase
    {
        private readonly IRateRepository rateRepository;

        public RatesController(IRateRepository rateRepository)
        {
            this.rateRepository = rateRepository;
        }

        [HttpGet]
        [Route("getratestbyhotelanddates/{id}/{startDate}/{endDate}")]
        public async Task<IActionResult> GetByHotelAndDates([FromRoute] int id, [FromRoute] DateOnly startDate, [FromRoute] DateOnly endDate)
        {
            var rates = await rateRepository.GetByHotelAndDates(id,startDate, endDate);

            //var responseDto = new List<HotelDto>();

            //foreach (var item in hotels)
            //{
            //    responseDto.Add(new HotelDto { Id = item.Id, HotelName = item.HotelName });
            //}

            var response = new List<ListRatesByHotelAndDatesDto>();

            foreach (var item in rates)
            {
                response.Add(new ListRatesByHotelAndDatesDto
                {
                    Id = item.Id,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    RoomType = item.RoomType,
                    B2B = item.B2B,
                    WebBeds = item.WebBeds,
                    OurBestPrice = item.OurBestPrice,
                    OtherToPrice = item.OtherToPrice,
                    DiffEuro = (float)item.DiffEuro,
                    DiffPercent = (float)item.DiffPercent,


                });
            }


            return Ok(response);
        }

        [HttpGet]
        [Route("getallrates")]
        public async Task<IActionResult> GetAllRates()
        {
            var rates = await rateRepository.GetAllAsync();

            var response = new List<ListRatesDto>();

            foreach (var item in rates)
            {
                response.Add(new ListRatesDto
                {
                    Id = item.Id,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    RoomType = item.RoomType,
                    B2B = item.B2B,
                    WebBeds = item.WebBeds,
                    OurBestPrice = item.OurBestPrice,
                    OtherToPrice = item.OtherToPrice,
                    DiffEuro = (float)item.DiffEuro,
                    DiffPercent = (float)item.DiffPercent,


                });
            }


            return Ok(response);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public async Task<IActionResult> GetSingleRate([FromRoute] int id)
        {
            var rate = await rateRepository.GetByIdAsync(id);

            //var responseDto = new List<HotelDto>();

            //foreach (var item in hotels)
            //{
            //    responseDto.Add(new HotelDto { Id = item.Id, HotelName = item.HotelName });

            //}

            var response = new SingleRateDto
            {
                Id = rate.Id,
                StartDate = rate.StartDate,
                EndDate = rate.EndDate,
                RoomType = rate.RoomType,
                B2B = rate.B2B,
                WebBeds = rate.WebBeds,
                OurBestPrice = rate.OurBestPrice,
                OtherToPrice = rate.OtherToPrice,
                DiffEuro = (float)rate.DiffEuro,
                DiffPercent = (float)rate.DiffPercent,

            };


            return Ok(response);
        }

        [HttpGet]
        [Route("getlistratesbyHotel/{id}")]
        public async Task<IActionResult> GetListRatesByHotel([FromRoute] int id)
        {
            var rates = await rateRepository.GetListByHotelIdAsync(id);

            var response = new List<ListRatesByHotelDto>();

            foreach (var item in rates)
            {
                response.Add(new ListRatesByHotelDto
                {
                    Id = item.Id,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    RoomType = item.RoomType,
                    B2B = item.B2B,
                    WebBeds = item.WebBeds,
                    OurBestPrice = item.OurBestPrice,
                    OtherToPrice = item.OtherToPrice,
                    DiffEuro = (float)item.DiffEuro,
                    DiffPercent = (float)item.DiffPercent,


                });
            }


            return Ok(response);
        }

        [HttpGet]
        [Route("getbydates/{startDate}/{endDate}")]
        public async Task<IActionResult> GetByDates([FromRoute] DateOnly startDate, [FromRoute] DateOnly endDate)
        {
            var rates = await rateRepository.GetByDatesAsync(startDate, endDate);

            var response = new List<ListRatesByDatesDto>();

            foreach (var item in rates)
            {
                response.Add(new ListRatesByDatesDto
                {
                    Id = item.Id,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    RoomType = item.RoomType,
                    B2B = item.B2B,
                    WebBeds = item.WebBeds,
                    OurBestPrice = item.OurBestPrice,
                    OtherToPrice = item.OtherToPrice,
                    DiffEuro = (float)item.DiffEuro,
                    DiffPercent = (float)item.DiffPercent,


                });
            }


            return Ok(response);
        }

        [HttpGet]
        [Route("count")]
        public async Task<IActionResult> GetCount()
        {
            int count = await rateRepository.GetCount();

            //var responseDto = new List<HotelDto>();

            //foreach (var item in hotels)
            //{
            //    responseDto.Add(new HotelDto { Id = item.Id, HotelName = item.HotelName });
            //}


            return Ok(count);
        }
    }
}
