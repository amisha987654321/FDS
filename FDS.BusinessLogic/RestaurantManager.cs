using FDS.BusinessEntities;
using FDS.BusinessLogic.Interface;
using FDS.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessLogic
{
    public class RestaurantManager : IRestaurantManager
    {
        private readonly IRestaurantRepository _restaurantRepository;
        public RestaurantManager(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public IList<RestaurantViewModel> GetRestaurants()
        {
            IList<RestaurantViewModel> restaurantViewModels = new List<RestaurantViewModel>();
            var restaurants = _restaurantRepository.GetRestaurants();
            if(restaurants.Any())
            {
                foreach (var restaurant in restaurants)
                {
                    var restaurantViewModel = new RestaurantViewModel()
                    {
                        RestaurantId = restaurant.RestaurantId,
                        RestaurantName = restaurant.RestaurantName,
                        OwnerName = restaurant.OwnerName,
                        Availibility = restaurant.RestaurantName + " is available between " + restaurant.ShiftInTime + " and " + restaurant.ShiftOutTime,
                        ContactDetails = "EmailID : " + restaurant.Email + " & Phone Number : " + restaurant.PhoneNumber,
                        Password = restaurant.Password,
                        //Email = restaurant.Email,
                        //PhoneNumber = restaurant.PhoneNumber,
                        //ShiftInTime = restaurant.ShiftInTime,
                        //ShiftOutTime = restaurant.ShiftOutTime,
                        GstNumber = restaurant.GstNumber,
                        BankAccountNumber = restaurant.BankAccountNumber,
                        FssaiCertificate = restaurant.FssaiCertificate,
                        PassbookFirstPage = restaurant.PassbookFirstPage,
                        Status = (bool)restaurant.Status,
                        AddressID = (int)restaurant.AddressId
                    };
                    restaurantViewModels.Add(restaurantViewModel);
                }
            }
           return restaurantViewModels;
        }
        public RestaurantViewModel GetRestaurantById(int id)
        {
            var restaurantViewModel = new RestaurantViewModel();
            var restaurant = _restaurantRepository.GetRestauranById(id);
            if (restaurant != null)
            {
                restaurantViewModel = new RestaurantViewModel()
                {
                    RestaurantId = restaurant.RestaurantId,
                    RestaurantName = restaurant.RestaurantName,
                    OwnerName = restaurant.OwnerName,
                    Availibility = restaurant.RestaurantName + " is available between " + restaurant.ShiftInTime + " and " + restaurant.ShiftOutTime,
                    ContactDetails = "EmailID : " + restaurant.Email + " Phone Number : " + restaurant.PhoneNumber,
                    Password = restaurant.Password,
                    //Email = restaurant.Email,
                    //PhoneNumber = restaurant.PhoneNumber,
                    //ShiftInTime = restaurant.ShiftInTime,
                    //ShiftOutTime = restaurant.ShiftOutTime,
                    GstNumber = restaurant.GstNumber,
                    BankAccountNumber = restaurant.BankAccountNumber,
                    FssaiCertificate = restaurant.FssaiCertificate,
                    PassbookFirstPage = restaurant.PassbookFirstPage,
                    Status = (bool)restaurant.Status,
                    AddressID = (int)restaurant.AddressId

                };
            }
                return restaurantViewModel;
        }
    }
}
