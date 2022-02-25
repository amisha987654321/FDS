using FDS.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessLogic.Interface
{
    public interface IAddressManager
    {
        Task<IList<AddressViewModel>> GetAddresses();
        Task<AddressViewModel> GetAddressById(int id);
    }
}
