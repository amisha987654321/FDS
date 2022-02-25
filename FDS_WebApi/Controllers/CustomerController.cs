using FDS.BusinessEntities;
using FDS.BusinessLogic.Interface;
using Microsoft.AspNetCore.Mvc;

//For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FDS_WebApi.Controllers
{
    [Route("api/[controller]")]
    
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerManager _customerManager;
        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        [HttpGet, Route("Customers")]
        
        public IActionResult GetCustomers()
        {
            var customers = _customerManager.GetCustomers();
            if (customers == null || !customers.Any())
            {
                return NotFound();
            }
            return Ok(customers);
        } 
        [HttpGet, Route("Customer{id}")]
        public IActionResult GetCustomerById(int id)
        {
            if(id <= 0)
            {
                return NotFound();
            }
            var customer = _customerManager.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
        [HttpPost, Route("Add")]

        public IActionResult AddCustomer(CustomerViewModel customerModel )
        {
            if(customerModel == null)
            {
                return NotFound();
            }

            _customerManager.AddCustomer(customerModel);
            return Ok(true);
        }
        [HttpPut, Route("Update")]
        public IActionResult UpdateCustomer(CustomerViewModel customerModel)
        {
            if (customerModel == null)
            {
                return NotFound();
            }

            _customerManager.UpdateCustomer(customerModel);
            return Ok(true);
        }

        [HttpDelete, Route("Delete")]
        public IActionResult DeleteCustomer(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            _customerManager.DeleteCustomer(id);
            return Ok(true);

        }
        


    }
}
