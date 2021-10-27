using webAPI2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using webAPI2.Services.AdultService;

namespace webAPI2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
        private readonly IAdultService _adultService;

        public AdultController(IAdultService adultService)
        {
            _adultService = adultService;
        }


        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Adult>> Get()
        {
            return Ok(_adultService.Get());
        }

        [HttpGet("{id}")]

        public ActionResult<Adult> GetSingle(int id)
        {
            return Ok(_adultService.GetSingle(id));
        }

        [HttpPost]
        public ActionResult<List<Adult>> AddAdult(Adult newAdult)
        {
            return Ok(_adultService.AddAdult(newAdult));
        }
    }
}