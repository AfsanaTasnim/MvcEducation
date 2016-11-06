
namespace MvcEducation.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Result
    {
        public int ResultID { get; set; }
        public int courseID { get; set; }
        public int studentID { get; set; }
        public string Subjects { get; set; }
        public Grade? Grade { get; set; }

        
        public virtual Student Student { get; set; }
    }
}