using FDS.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessLogic.Interface
{
    public interface IRestaurantManager
    {
        IList<RestaurantViewModel> GetRestaurants();
        RestaurantViewModel GetRestaurantById(int id);
    }
}
