using FDS.BusinessLogic.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FDS_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantManager _restaurantManager;
        public RestaurantController(IRestaurantManager restaurantManager)
        {
            _restaurantManager = restaurantManager;
        }

        [HttpGet, Route("Restaurants")]
        public IActionResult GetRestaurants()
        {
            var restaurants = _restaurantManager.GetRestaurants();
            if(restaurants == null || !restaurants.Any())
            {
                return NotFound();
            }
            return Ok(restaurants);

        }

        [HttpGet, Route("Restaurant{id}")]
        public IActionResult GetRestaurantById(int id)
        {
            var restaurant = _restaurantManager.GetRestaurantById(id);
            if (id <= 0)
            {
                return NotFound();
            }
            if (restaurant == null)
            {
                return NotFound();
            }
            return Ok(restaurant);

        }

        //// GET: api/<RestaurantController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<RestaurantController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<RestaurantController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<RestaurantController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<RestaurantController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
