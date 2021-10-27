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
        string text = System.IO.File.ReadAllText(@"adults.json");
        
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Adult>>Get()
        {
            List<Adult> adultList = new List<Adult>();
            adultList = JsonConvert.DeserializeObject<List<Adult>>(text);
            return Ok(adultList);
        }

        [HttpGet("{id}")]

        public ActionResult<Adult>GetSingle(int id)
        {
            List<Adult> adultList = new List<Adult>();
            adultList = JsonConvert.DeserializeObject<List<Adult>>(text);
            return Ok(adultList.First(a => a.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Adult>> AddAdult(Adult newAdult)
        {  
            List<Adult> adultList = new List<Adult>();
            adultList = JsonConvert.DeserializeObject<List<Adult>>(text);
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