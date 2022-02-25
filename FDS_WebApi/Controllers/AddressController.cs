using FDS.BusinessLogic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FDS_WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressManager _addressManager;
        public AddressController(IAddressManager addressManager)
        {
            _addressManager = addressManager;
        }

        [HttpGet]
        [Route("Addresses")]    
        public async Task< IActionResult> GetAddresses()
        {
            var addresses = await _addressManager.GetAddresses();
            return Ok(addresses);
        }

        [HttpGet, Route("Address{id}")]       
        public async Task< IActionResult> GetAddressById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            var address = await _addressManager.GetAddressById(id);
            if (address == null)
            {
                return NotFound();
            }
            return Ok(address);
        }
    }
}
