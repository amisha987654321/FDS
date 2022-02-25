using FDS.DataAccess.Database;
using FDS.DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private FDSContext _dbcontext;
        public CustomerRepository(FDSContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IList<Customer> GetCustomers()
        {            
            var customers = _dbcontext.Customers.Include(x => x.Addresses).ToList();
            return customers;
        }
        public void AddCustomer(Customer customer)
        {
            _dbcontext.Add(customer);
            _dbcontext.SaveChanges();

            foreach (var address in customer.Addresses)
            {
                address.CustomerId = customer.CustomerId;
                _dbcontext.Add(address);
                _dbcontext.SaveChanges();
            }          

        }
        public void UpdateCustomer(Customer customer)
        {
            var customerDetail = _dbcontext.Customers.FirstOrDefault(x=> x.CustomerId == customer.CustomerId);
            if(customerDetail != null)
            {
                customerDetail.Firstname = customer.Firstname;
                customerDetail.LastName= customer.LastName;

                _dbcontext.Update(customerDetail);
                _dbcontext.SaveChanges();
            }

            foreach (var address in customer.Addresses)
            {
                var addressDetail = _dbcontext.Addresses.FirstOrDefault(x=> x.AddressId == address.CustomerId);
                if(addressDetail != null)
                {
                    addressDetail.AddressLine1 = address.AddressLine1;
                    addressDetail.City = address.City;

                    _dbcontext.Add(address);
                    _dbcontext.SaveChanges();
                }
            }

        }

        public void DeleteCustomer(int id)
        {
            var customerDetail = _dbcontext.Customers.FirstOrDefault(x => x.CustomerId == id);
            if (customerDetail != null)
            {         

                _dbcontext.Remove(customerDetail);
                _dbcontext.SaveChanges();
            }

        }



        public Customer GetCustomerById(int id)
        {
            var customer = GetCustomers().FirstOrDefault(x => x.CustomerId == id);
            if (customer != null)
            {
                return customer;
            }
            return new Customer();
        }
        
    }
}
