using Resume.Models;

namespace Resume.Providers
{
    public interface IPersonProvider
    {
        IEnumerable<PersonModel> GetFullInfo();
    }
    public class PersonProvider : IPersonProvider
    {
        public IEnumerable<PersonModel> GetFullInfo()
        {
            var re = new List<PersonModel>();
            var exp = new Education { CollegeName = "Georgian College", Diploma = "Advanced Diploma", StartDate = DateOnly.MaxValue, EndDate = DateOnly.MinValue };
            re.Add(new PersonModel { FullName = "Danil Borisov", Occupation = "Sasa", Description = "asasqww", ShortDescription = "sasassas", Education = exp});
           

            

            return re;
        }
    }
}
