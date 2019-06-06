using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SignupDTO
    {
        string studentId;
        string classId;
        string status;

        public SignupDTO(string studentId, string classId, string status)
        {
            this.studentId = studentId;
            this.classId = classId;
            this.status = status;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string ClassId { get => classId; set => classId = value; }
        public string Status { get => status; set => status = value; }
    }
}
