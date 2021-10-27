using webAPI2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;




namespace webAPI2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
        //private static Adult emptyAdult = new Adult();
        //string text = System.IO.File.ReadAllText(@"adults.json");

        public static string text { get; set; } = System.IO.File.ReadAllText(@"adults.json");
        public static List<Adult> adultList { get; set; } =JsonConvert.DeserializeObject<List<Adult>>(text);
        
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Adult>>Get()
        {
            return Ok(adultList);
        }

        [HttpGet("{id}")]

        public ActionResult<Adult>GetSingle(int id)
        {
            return Ok(adultList.First(a => a.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Adult>> AddAdult(Adult newAdult)
        {  
            adultList.Add(newAdult);
            string json = JsonConvert.SerializeObject(adultList);
            System.IO.File.WriteAllText(@"adults.json", json);
            return Ok(adultList);
        }
            // Console.WriteLine();
            // foreach( Adult a in adultList )
            // {
            //     Console.WriteLine(a.FirstName);
            // }
    }
}