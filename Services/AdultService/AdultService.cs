using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using webAPI2.Models;

namespace webAPI2.Services.AdultService
{
    public class AdultService : IAdultService
    {
 
        public static string text { get; set; } = System.IO.File.ReadAllText(@"adults.json");
        public static List<Adult> adultList { get; set; } =JsonConvert.DeserializeObject<List<Adult>>(text);
        public List<Adult> AddAdult(Adult newAdult)
        {
            adultList.Add(newAdult);
            string json = JsonConvert.SerializeObject(adultList);
            System.IO.File.WriteAllText(@"adults.json", json);
            return adultList;
        }

        public List<Adult> Get()
        {
            return adultList;
        }

        public Adult GetSingle(int id)
        {
             return adultList.First(a => a.Id == id);
        }
    }
}