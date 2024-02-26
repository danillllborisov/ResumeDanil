using Resume.Models;

namespace Resume.Providers
{
    public interface IExperienceProvider
    {
        IEnumerable<ExperienceModel> GetFullExperience();
    }
    public class ExperienceProvider : IExperienceProvider
    {
       public IEnumerable<ExperienceModel> GetFullExperience()
        {
            var re = new List<ExperienceModel>();
            re.Add(new ExperienceModel { Role = "role", CompanyName = "Name" , StartDate = DateOnly.MaxValue, EndDate = DateOnly.MinValue, Location = "Location", Accomplishments = new List<string> { "acc1", "acc2", "acc3" }   });
            re.Add(new ExperienceModel { Role = "role", CompanyName = "Name", StartDate = DateOnly.MaxValue, EndDate = DateOnly.MinValue, Location = "Location", Accomplishments = new List<string> { "acc1", "acc2", "acc3" } });


            return re;
        }
    }
}
