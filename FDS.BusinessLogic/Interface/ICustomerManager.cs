using FDS.BusinessEntities;

namespace FDS.BusinessLogic.Interface
{
    public interface ICustomerManager
    {
        IList<CustomerViewModel> GetCustomers();
        CustomerViewModel GetCustomerById(int id);
        public void AddCustomer(CustomerViewModel customerViewModel);

        public void UpdateCustomer(CustomerViewModel customerViewModel);
        public void DeleteCustomer(int id);

    }
}
