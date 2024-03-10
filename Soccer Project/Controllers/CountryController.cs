using Business_Logic.Interface;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Soccer_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private ICountryService service;

        public CountryController(ICountryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public List<Country> getAll()
        {
            return service.getAll();
        }
    }
}
