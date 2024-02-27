using Microsoft.AspNetCore.Http;
using Resume.Models;

namespace Resume.Providers
{
    public interface IPersonProvider
    {
        IEnumerable<PersonModel> GetFullInfo();
    }
    public class PersonProvider : IPersonProvider
    {
        private readonly IConfiguration _configuration;
        public PersonProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<PersonModel> GetFullInfo()
        {
            var person = new List<PersonModel>();

            var name = _configuration["PersonInfo:Name"];
            var occupation = _configuration["PersonInfo:Occupation"];
            var desc = _configuration["PersonInfo:Desc"];
            var shortDesc = _configuration["PersonInfo:ShortDesc"];

            var collegeName = _configuration["Education:CollegeName"];
            var diploma = _configuration["Education:Diploma"];
            
            var startDate = _configuration["Education:StartDate"];
            var endDate = _configuration["Education:EndDate"];

            var education = new Education 
            {
                CollegeName = collegeName, 
                Diploma = diploma, 
                StartDate = startDate, 
                EndDate = endDate 
            };

            person.Add(new PersonModel 
            {
                FullName = name, 
                Occupation = occupation, 
                Description = desc, 
                ShortDescription = shortDesc, 
                Education = education 
            });
        
            return person;
        }
    }
}
