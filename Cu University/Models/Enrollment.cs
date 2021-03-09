namespace Cu_University.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        private int pEnrollmentID, pCourseID, pStudentID;
        public Grade? Grade { get; set; }

        public int EnrollmentID {
            get { return pEnrollmentID; }
            set { pEnrollmentID = value; }
        }
        public int CourseID {
            get { return pCourseID; }
            set { pCourseID = value; }
        }
        public int StudentID {
            get { return pStudentID; }
            set { pStudentID = value; }
        }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}