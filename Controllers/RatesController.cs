using BedBankReports.API.Models.Dto.Hotel;
using BedBankReports.API.Models.Dto.Login;
using BedBankReports.API.Models.Dto.Rate;
using BedBankReports.API.Repositories.Implementation;
using BedBankReports.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
                    DiffEuro = item.DiffEuro,
                    DiffPercent = item.DiffPercent,


                });
            }


            return Ok(response);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateRateAsync([FromBody]CreateRateDto crateRateDto)
        {
            await  rateRepository.CreateRateAsync(crateRateDto);
            return Ok(crateRateDto);
            
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
                    DiffEuro = item.DiffEuro,
                    DiffPercent = item.DiffPercent,


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
                DiffEuro = rate.DiffEuro,
                DiffPercent = rate.DiffPercent,

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
                    DiffEuro = item.DiffEuro,
                    DiffPercent = item.DiffPercent,


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
                    DiffEuro = item.DiffEuro,
                    DiffPercent = item.DiffPercent,


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

        [HttpGet]
        [Route("getLastDateTime")]
        public async Task<IActionResult> GetLastDateTime()
        {
            DateTime date = await rateRepository.GetLastDateTime();

            //var responseDto = new List<HotelDto>();

            //foreach (var item in hotels)
            //{
            //    responseDto.Add(new HotelDto { Id = item.Id, HotelName = item.HotelName });
            //}


            return Ok(date);
        }

        [HttpGet]
        [Route("getlistratedatesbyHotel/{id}")]
        public async Task<IActionResult> GetListRateDatesByHotel([FromRoute] int id)
        {
            var result =await rateRepository.GetListRateDatesByHotelAsync(id);
            return Ok(result);
        }
        
        [HttpGet]
        [Route("getroomsbyhotelanddate/{id}/{startDate}/{endDate}")]
        public async Task<IActionResult> GetRoomsByHotelAndDates([FromRoute] int id, [FromRoute] DateOnly startDate, [FromRoute] DateOnly endDate)
        {
            var result = await rateRepository.GetRoomsByHotelAndDates(id,startDate,endDate);
            return Ok(result);
        }
        [HttpGet]
        [Route("getratesbyroomsandhotelanddate/{id}/{startDate}/{endDate}/{roomType}")]
        public async Task<IActionResult> GetRatesByRoomAndHotelAndDates([FromRoute] int id, [FromRoute] DateOnly startDate, [FromRoute] DateOnly endDate, [FromRoute] string roomType)
        {
            var result = await rateRepository.GetRatesByRoomAndHotelAndDates(id, startDate, endDate,roomType);
            return Ok(result);
        }
    }
}
