using FDS.DataAccess.Database;
using FDS.DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.DataAccess
{
    public class AddressRepository : IAddressRepository
    {
        private FDSContext _dbContext;
        public AddressRepository(FDSContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<Address>> GetAddresses()
        {
            var addresses = await _dbContext.Addresses.ToListAsync();
            return addresses;
        }
        public async Task<Address> GetAddressById(int id)
        {
            //var address = (await GetAddresses()).FirstOrDefault(x => x.AddressId == id);
            var address = await _dbContext.Addresses.FirstOrDefaultAsync(x => x.AddressId == id);
            if (address != null)
            {
                return address;
            }
            return new Address();
        }

    }
}
