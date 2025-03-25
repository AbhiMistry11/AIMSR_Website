namespace AIMSRCollegeWebsite.Models
{
    public class CourseDetailsViewModel
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseImage { get; set; }
        public string CourseDuration { get; set; }
        public decimal TotalFees { get; set; }
        public string DegreeType { get; set; }
        public List<SemesterCurriculum> Curriculum { get; set; }
        public List<string> CareerProspects { get; set; }

        // Add these two new properties
        public string OverviewTitle { get; set; }
        public string OverviewDetailedDescription { get; set; }
        public List<string> OverviewPoints { get; set; }
    }

    public class SemesterCurriculum
    {
        public int SemesterNumber { get; set; }
        public List<string> Subjects { get; set; }
    }
}