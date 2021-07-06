using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cu_University.Models
{
    public class Student
    {
        private int pID;

        private string pLastName;

        private string pFirstMidName;

        private DateTime pEnrollmentDate;

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public int ID {
            get { return pID; }
            set { pID = value; }
        }

        [Required(ErrorMessage = "O campo Sobrenome é obrigatório")]
        public string LastName
        {
            get { return pLastName; }
            set { pLastName = value; }
        }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string FirstMidName
        {
            get { return pFirstMidName; }
            set { pFirstMidName = value; }
        }

        [Required(ErrorMessage = "O campo Data de Inscrição é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate
        {
            get { return pEnrollmentDate; }
            set { pEnrollmentDate = value; }
        }
    }
}