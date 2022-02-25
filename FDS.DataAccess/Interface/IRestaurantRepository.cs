using FDS.DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.DataAccess.Interface
{
    public interface IRestaurantRepository
    {
        IList<Restaurant> GetRestaurants();
        Restaurant GetRestauranById(int id);

    }
}
