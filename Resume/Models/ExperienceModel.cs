namespace Resume.Models
{
    public class ExperienceModel
    {
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public List<string> Accomplishments { get; set; }
    }
}
