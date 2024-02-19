public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public string Description { get; set; }
    public string Duration { get; set; }
    public int Amount { get; set; }
    
    // Navigation property for related enquiries
    public ICollection<Enquiry> Enquiries { get; set; }
}