using BedBankReports.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BedBankReports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISaleRepository saleRepository;

        public SalesController(ISaleRepository saleRepository)
        {
            this.saleRepository = saleRepository;
        }

        [HttpGet]
        [Route("getallsales")]
        public async Task<IActionResult> GetAllSales()
        {
            var hotels = await saleRepository.GetAllAsync();



            return Ok(hotels);
        }

        [HttpGet]
        [Route("getsalesbyid/{id}")]
        public async Task<IActionResult> GetSaleById([FromRoute] int id)
        {
            var sale = await saleRepository.GetByIdAsync(id);

            if (sale is null)
            {
                return NotFound();
            }


            return Ok(sale);
        }

        [HttpGet]
        [Route("getsalesbydate/{date}")]
        public async Task<IActionResult> GetSaleByDate([FromRoute] DateOnly date) //apiden gelen format : ay-gun-yil yada ay.gun.yil formati olmali db dekı format ay-gun - yıl
        {
            
            //var a =date.ToShortDateString();
            //string x = $"{date.Year}-{date.Month}-{date.Day}";

            var sale = await saleRepository.GetByDateAsync(date);

            if (sale is null)
            {
                return NotFound();
            }


            return Ok(sale);
        }

        [HttpGet]
        [Route("salescount")]
        public async Task<IActionResult> GetCount()
        {
            int count = await saleRepository.GetCount();

            return Ok(count);
        }
    }
}
