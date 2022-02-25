namespace FDS.BusinessEntities
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            Address = new List<AddressViewModel>();
            //addresslistFromCustomerViewModel = new List<string>();
        }
        public int CustomerId { get; set; }
        public string? Firstname { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public bool? Subscription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CustomerType { get; set; }
        public IList<AddressViewModel> Address { get; set; }
        public string addressStringFromCustomerViewModel { get; set; }
        public List<string> addresslistFromCustomerViewModel { get; set; }

    }
}
