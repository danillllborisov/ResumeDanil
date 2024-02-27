using Microsoft.Extensions.Configuration;
using Resume.Models;

namespace Resume.Providers
{
    public interface IExperienceProvider
    {
        IEnumerable<ExperienceModel> GetFullExperience();
    }
    public class ExperienceProvider : IExperienceProvider
    {
        private readonly IConfiguration _configuration;
        public ExperienceProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<ExperienceModel> GetFullExperience()
        {

            List<ExperienceModel> jobDetails = _configuration.GetSection("JobDetails").Get<List<ExperienceModel>>();

            return jobDetails;
        }
    }
}
