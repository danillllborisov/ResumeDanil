using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using Resume.Providers;

namespace Resume.Controllers
{
    [ApiController]
    [Route("experience")]
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceProvider _experienceProvider;

        
        public ExperienceController(IExperienceProvider experienceProvider)
        {
            _experienceProvider = experienceProvider;
        }

        [HttpGet]
        public IEnumerable<ExperienceModel> GetAll()
        {
            return _experienceProvider.GetFullExperience();
        }

    }
}
