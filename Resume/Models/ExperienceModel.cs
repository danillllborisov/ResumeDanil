namespace Resume.Models
{
    public class ExperienceModel
    {
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<string> Accomplishments { get; set; }
        public List<string> Technologies { get; set; }
    }
}
