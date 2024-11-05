using BedBankReports.API.Data;
using BedBankReports.API.Models.Domain;
using BedBankReports.API.Models.Dto.Rate;
using BedBankReports.API.Repositories.Interface;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;
using System.Reflection;

namespace BedBankReports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly string AppDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        private static List<FileRecord> fileDB = new List<FileRecord>();
        ApplicationDbContext dbContext = new ApplicationDbContext();



        private readonly IFileRepository fileRepository;
        private readonly IHotelRepository hotelRepository;
        private readonly IRateRepository rateRepository;

        public FilesController(IFileRepository fileRepository, IHotelRepository hotelRepository)
        {
            this.fileRepository = fileRepository;
            this.hotelRepository = hotelRepository;
        }





        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<HttpResponseMessage> PostAsync([FromForm] FileModel model)
        {


            try
            {
                FileRecord file = await fileRepository.SaveToServer(model.MyFile);

                if (!string.IsNullOrEmpty(file.FilePath))
                {

                    file.Description = model.Description;


                    await fileRepository.SaveToDB(file);

                    await ReadExcelFileAndSave(model.MyFile, file.FilePath);
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message),
                };
            }




        }

        private async Task ReadExcelFileAndSave(IFormFile myFile, string filePath)
        {

            var dataSet = new DataSet();
            using var workBook = new XLWorkbook(filePath);
            foreach (var workSheet in workBook.Worksheets)
            {
                var dt = new DataTable(workSheet.Name);
                //Assumes that the first column of the excel sheet having headers
                workSheet.FirstRowUsed().CellsUsed().ToList()
                    .ForEach(x =>
                    {
                        dt.Columns.Add(x.Value.ToString());
                    });

                foreach (var row in workSheet.RowsUsed().Skip(1))
                {
                    var dr = dt.NewRow();
                    for (var i = 0; i < dt.Columns.Count; i++)
                    {
                        dr[i] = row.Cell(i + 1).Value.ToString();
                    }
                    dt.Rows.Add(dr);
                }
                dataSet.Tables.Add(dt);
            }

            var rateListFromDataTable = Helpers.DatatableToGenericHelper.DataTableToEntityList<TestExcel>(dataSet.Tables[0]);

            foreach (var item in rateListFromDataTable)
            {
                var hotel = await hotelRepository.GetByNameAsync(item.HotelName);

                if (hotel == null)
                {
                    hotel = await hotelRepository.CreateHotelAsync(new Hotel { HotelName = item.HotelName, CreatedDate = DateTime.UtcNow });
                }

                CreateRateDto rate = new CreateRateDto();
                rate.StartDate = new DateOnly(
                                   Int32.Parse(item.RezDate.Split('|')[0].Split(".")[2]),
                                   Int32.Parse(item.RezDate.Split('|')[0].Split(".")[1]),
                                   Int32.Parse(item.RezDate.Split('|')[0].Split(".")[0]));
                rate.EndDate = new DateOnly(
                                   Int32.Parse(item.RezDate.Split('|')[1].Split(".")[2]),
                                   Int32.Parse(item.RezDate.Split('|')[1].Split(".")[1]),
                                   Int32.Parse(item.RezDate.Split('|')[1].Split(".")[0]));
                rate.RoomType = item.RoomType;
                    rate.B2B = float.Parse(item.B2B, System.Globalization.CultureInfo.InvariantCulture);
                rate.WebBeds = float.Parse(item.WebBeds, System.Globalization.CultureInfo.InvariantCulture);
                rate.OurBestPrice = float.Parse(item.OurBestPrice, System.Globalization.CultureInfo.InvariantCulture);
                rate.OtherToPrice = float.Parse(item.OtherToPrice, System.Globalization.CultureInfo.InvariantCulture);
                rate.CreatedDate = DateTime.UtcNow;
                rate.HotelId = hotel.Id;
                await rateRepository.CreateRateAsync(rate);


            }



        }


        [HttpGet]
        public async Task<List<FileRecord>> GetAllFiles()
        {

            return await fileRepository.GetAllFiles();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> DownloadFile(int id)
        {
            if (!Directory.Exists(AppDirectory))
                Directory.CreateDirectory(AppDirectory);

            //getting file from inmemory obj
            //var file = fileDB?.Where(n => n.Id == id).FirstOrDefault();
            //getting file from DB
            var file = await fileRepository.GetById(id);

            var path = Path.Combine(AppDirectory, file?.FilePath);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            var contentType = "APPLICATION/octet-stream";
            var fileName = Path.GetFileName(path);

            return File(memory, contentType, fileName);
        }


    }



}



public class TestExcel
{
    public string GIATA { get; set; }
    public string HotelName { get; set; }
    public string RezDate { get; set; }
    public string RoomType { get; set; }
    public string B2B { get; set; }
    public string WebBeds { get; set; }
    public string OurBestPrice { get; set; }
    public string OtherToPrice { get; set; }


}