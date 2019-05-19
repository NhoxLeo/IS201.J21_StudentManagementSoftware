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
        string studentAddress;

        public StudentDTO(string courseId, string studentName, string studentAddress)
        {
            this.studentId = courseId;
            this.studentName = studentName;
            this.studentAddress = studentAddress;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }
    }
}
