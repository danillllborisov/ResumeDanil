namespace Resume.Models
{
    public class PersonModel
    {
        public string FullName { get; set; }
        public string Occupation { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public Education Education { get; set; }
        
    }
    public class Education
    {
        public string CollegeName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set;}
        public string Diploma { get; set; }
    }
}
