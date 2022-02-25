using FoodTruckService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.Api.Store.Controllers
{
    /// <summary>
    /// Controlller food truck
    /// </summary>   
    ///  [ApiController]
    [ApiController]
    [Route("/foodtruck")]
    public class FoodTruckController : ControllerBase
    {
        private readonly IFoodtruckClient _foodtruckClient;
        public FoodTruckController(IFoodtruckClient foodtruckClient)
        {
            _foodtruckClient = foodtruckClient;
        }
        /// <summary>
        /// Get Food Truckand paging data
        /// </summary>         
        /// <param name="day">This  parameter define  the day order</param>
        /// <param name="time">This parameter define time open</param>
        /// <param name="page">This parameter define  page num you want to get</param>
        /// <param name="take">This parameter define how much item you want to get</param>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>        
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response> 
        //salarystimate
        [HttpGet("GetTruck")]
        public async Task<IActionResult> GetTruck(string day, string time, int page = 1, int take = 10)
        {
            var list = await _foodtruckClient.GetFoodTruckByDatetime(day, time, page,take);
            return Ok(list);
        }
    }
}

