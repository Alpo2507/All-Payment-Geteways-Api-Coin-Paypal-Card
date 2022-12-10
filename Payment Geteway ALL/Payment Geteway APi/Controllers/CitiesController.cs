using Microsoft.AspNetCore.Mvc;
using Ocelot.Demo.Api2.Models;

namespace Ocelot.Demo.Api2.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase

    {
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.Instance.Cities);
        }


        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        { 
            var cities = CitiesDataStore.Instance.Cities.FirstOrDefault(c => c.Id == id);

            if (cities == null)
            {
                return NotFound();                
            }
            return Ok(cities);
        }
        #region Redundant
        //public JsonResult GetCitiesOld()
        //{
        //    return new JsonResult(
        //        new List<Object> {
        //            new { id = 1, City = "Toronto"},
        //            new { id = 2, City = "New Delhi"},
        //            new { id = 3, City = "Dallas"},
        //            new { id = 4, City = "Melbourne"},
        //            new { id = 5, City = "London" }
        //        });
        //}

        //public JsonResult GetCities()
        //{
        //    return new JsonResult(CitiesDataStore.Instance.Cities);
        //}
        #endregion
    }
}
