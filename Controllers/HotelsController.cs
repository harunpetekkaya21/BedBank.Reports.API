using BedBankReports.API.Models.Dto.Hotel;
using BedBankReports.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BedBankReports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelRepository hotelRepository;

        public HotelsController(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }

        [HttpGet]
        [Route("getallhotels")]
        public async Task<IActionResult> GetAllHotels() 
        {
            var hotels = await hotelRepository.GetAllAsync();

            var responseDto = new List<HotelDto>();

            foreach (var item in hotels)
            {
                responseDto.Add(new HotelDto { Id = item.Id, HotelName = item.HotelName });
            }


            return Ok(responseDto);
        }

        [HttpGet]
        [Route("gethotelbyid/{id}")]
        public async Task<IActionResult> GetHotelById([FromRoute]int id)
        {
            
            var hotel = await hotelRepository.GetByIdAsync(id);

            if (hotel is null)
            {
                return NotFound();
            }

            var responseDto= new HotelDto { HotelName = hotel.HotelName ,Id=hotel.Id};


            return Ok(responseDto);
        }

        [HttpGet]
        [Route("getcount")]
        public async Task<IActionResult> GetCount()
        {
            int count = await hotelRepository.GetCount();

            return Ok(count);
        }
    }
}
