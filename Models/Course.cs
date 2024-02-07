using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso_MVC_8_0_VS2022.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string ?Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> ?Enrollments { get; set; }
    }
}




