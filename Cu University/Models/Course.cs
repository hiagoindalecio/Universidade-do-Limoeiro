using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cu_University.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        private int pCourseID, pCredits;
        private string pTitle;

        public int CourseID {
            get { return pCourseID; }
            set { pCourseID = value; }
        }
        public string Title {
            get { return pTitle; }
            set { pTitle = value; }
        }
        public int Credits {
            get { return pCredits; }
            set { pCredits = value; }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}