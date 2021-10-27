using System.Collections.Generic;
using webAPI2.Models;

namespace webAPI2.Services.AdultService
{
    public interface IAdultService
    {
        List<Adult> Get();

        Adult GetSingle(int id);

        List<Adult> AddAdult(Adult newAdult);
    }
}