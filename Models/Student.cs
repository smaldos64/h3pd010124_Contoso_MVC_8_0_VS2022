namespace Contoso_MVC_8_0_VS2022.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string ?LastName { get; set; }
        public string ?FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> ?Enrollments { get; set; }
    }
}
