using FDS.DataAccess.Database;
using FDS.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.DataAccess
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private FDSContext _dbcontext;
        public RestaurantRepository(FDSContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        
        public IList<Restaurant> GetRestaurants()
        {
            var restaurants = _dbcontext.Restaurants.ToList();
            return restaurants;           
        }
        public Restaurant GetRestauranById(int id)
        {
            var restaurant = GetRestaurants().FirstOrDefault(x=>x.RestaurantId == id);
            if(restaurant != null)
            {
                return restaurant;
            }
            return new Restaurant();
        }
    }
}
