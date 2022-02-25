using FDS.BusinessEntities;
using FDS.BusinessLogic.Interface;
using FDS.Common;
using FDS.DataAccess.Database;
using FDS.DataAccess.Interface;

namespace FDS.BusinessLogic
{
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerRepository _customerRepository;
        
        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        
        public IList<CustomerViewModel> GetCustomers()
        {
            IList<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();
            var customers = _customerRepository.GetCustomers();

            //Simple json cast
            //if (customers.Any())
            //{
            //    customerViewModels = customers.JsonCast<IList<CustomerViewModel>>();
            //}
            //return customerViewModels;


            //json cast with address
            if (customers.Any())
            {
                customerViewModels = customers.JsonCast<IList<CustomerViewModel>>();

                foreach (var customer in customerViewModels)
                {
                    customer.CustomerType = customer.Subscription == true ? "Subscribed user" : "Normal user";
                    foreach (var add in customer.Address)
                    {
                        customer.addressStringFromCustomerViewModel = add.AddressLine1;
                    }

                    customer.addresslistFromCustomerViewModel.Add(customer.addressStringFromCustomerViewModel);
                }
            }
            return customerViewModels;


            //if (customers.Any())
            //{
            //    foreach (var customer in customers)
            //    {
            //        var customerViewModel = new CustomerViewModel()
            //        {
            //            CustomerId = customer.CustomerId,
            //            Firstname = customer.Firstname,
            //            LastName = customer.LastName,
            //            Email = customer.Email,
            //            PhoneNumber = customer.PhoneNumber,
            //            Subscription = customer.Subscription,
            //            //CustomerType = customer.Subscription == true ? "Prime User" : "Normal User",
            //            //addressStringFromCustomerViewModel = customer.Addresses[0].AddressLine1 + ", " + customer.Addresses[0].AddressLine2 + ", " + customer.Addresses[0].City + ", " + customer.Addresses[0].State + ", " + customer.Addresses[0].Country + ", PIN - " + customer.Addresses[0].Zip

            //        };

            //        foreach (var cm in customerViewModels)
            //        {
            //            cm.CustomerType = cm.Subscription == true ? "Subscribed user" : "Normal user";
            //            foreach(var add in cm.Address)
            //            {
            //                cm.addressStringFromCustomerViewModel = add.AddressLine1;qqqqqqqqqqqq   
            //                cm.addresslistFromCustomerViewModel.Add(cm.addressStringFromCustomerViewModel);
            //            }
            //        }

            //        customerViewModels.Add(customerViewModel);

            //    }
            //}
            //return customerViewModels;
        }

        
        public CustomerViewModel GetCustomerById(int id)
        {           

            CustomerViewModel customerViewModel = new CustomerViewModel();
            var customer = _customerRepository.GetCustomerById(id);

            if (customer != null)
            {                         
                    customerViewModel = new CustomerViewModel
                    {
                        CustomerId = customer.CustomerId,
                        Firstname = customer.Firstname,
                        LastName = customer.LastName,
                        Email = customer.Email,
                        PhoneNumber = customer.PhoneNumber,
                        Subscription = customer.Subscription,
                        //CustomerType = customer.Subscription == true ? "Prime User" : "Normal User",
                        //AddressString = customer.Addresses[0].AddressLine1 + ", " + customer.Addresses[0].AddressLine2 + ", " + customer.Addresses[0].City + ", " + customer.Addresses[0].State + ", " + customer.Addresses[0].Country + ", PIN - " + customer.Addresses[0].Zip
                        
                    };              
                
            }
            return customerViewModel;
        }
        public void AddCustomer(CustomerViewModel customerViewModel)
        {
            _customerRepository.AddCustomer(customerViewModel.JsonCast<Customer>());
        }
        public void UpdateCustomer(CustomerViewModel customerViewModel)
        {
            _customerRepository.UpdateCustomer(customerViewModel.JsonCast<Customer>());
        }
        public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }
    }
}