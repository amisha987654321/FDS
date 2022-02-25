using FDS.BusinessEntities;
using FDS.BusinessLogic.Interface;
using FDS.Common;
using FDS.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessLogic
{
    public class AddressManager : IAddressManager
    {
        private readonly IAddressRepository _addressRepository;
        public AddressManager(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }


        public async Task<IList<AddressViewModel>> GetAddresses()
        {
            IList<AddressViewModel> addressViewModels = new List<AddressViewModel>();
            var Addresses = await _addressRepository.GetAddresses();

            //by json cast
            addressViewModels = Addresses.JsonCast<IList<AddressViewModel>>();
            return addressViewModels;


            //if (Addresses.Any())
            //{
            //    foreach (var address in Addresses)
            //    {
            //        var addressViewMode = new AddressViewModel()
            //        {
            //            AddressID = address.AddressId,
            //            AddressAsString = address.AddressLine1 +", "+ address.AddressLine2 + ", " + address.City + ", " + address.State + ", " + address.Country + ", Pin- " + address.Zip

            //        };
            //        addressViewModels.Add(addressViewMode);
            //    }
            //}
            //return addressViewModels;
        }

        public async Task<AddressViewModel> GetAddressById(int id)
        {
            AddressViewModel addressViewModel = new AddressViewModel();
            var address = await _addressRepository.GetAddressById(id);

            //by json cast
            addressViewModel = address.JsonCast<AddressViewModel>();
            return addressViewModel;


            //by conventional method
            //if (address != null)
            //{
            //    addressViewModel = new AddressViewModel
            //    {
            //        AddressID = address.AddressId,
            //        AddressAsString = address.AddressLine1 + ", " + address.AddressLine2 + ", " + address.City + ", " + address.State + ", " + address.Country + ", Pin- " + address.Zip

            //    };
            //}
            //return addressViewModel;
        }

    }
}
