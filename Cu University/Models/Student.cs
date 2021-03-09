using System;
using System.Collections.Generic;

namespace Cu_University.Models
{
    public class Student
    {
        private int pID;
        private string pLastName, pFirstMidName;
        private DateTime pEnrollmentDate;
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public int ID {
            get { return pID; }
            set { pID = value; }
        }

        public string LastName
        {
            get { return pLastName; }
            set { pLastName = value; }
        }

        public string FirstMidName
        {
            get { return pFirstMidName; }
            set { pFirstMidName = value; }
        }

        public DateTime EnrollmentDate
        {
            get { return pEnrollmentDate; }
            set { pEnrollmentDate = value; }
        }

        
    }
}