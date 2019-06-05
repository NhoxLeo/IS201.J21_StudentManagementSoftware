using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentDTO
    {
        string studentId;
        string studentName;
        string studentMail;
        string studentAddress;
        string studentPhone;
        DateTime studentBirthDate;

        public StudentDTO(string studentId, string studentName,string studentMail, string studentAddress,string studentPhone, DateTime studentBirthDate)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentMail = studentMail;
            this.studentAddress = studentAddress;
            this.studentPhone = studentPhone;
            this.studentBirthDate = studentBirthDate;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentMail { get => studentMail; set => studentMail = value; }
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }
        public string StudentPhone { get => studentPhone; set => studentPhone = value; }
        public DateTime StudentBirthDate { get => studentBirthDate; set => studentBirthDate = value; }
    }
}
