using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using Resume.Providers;

namespace Resume.Controllers
{
    [ApiController]
    [Route("personInfo")]
    public class PersonController
    {
        private readonly IPersonProvider _personProvider;

        public PersonController(IPersonProvider personProvider)
        {
            _personProvider = personProvider;
        }

        [HttpGet]
        public IEnumerable<PersonModel> GetInfo()
        {
            return _personProvider.GetFullInfo();
        }
    }
}
