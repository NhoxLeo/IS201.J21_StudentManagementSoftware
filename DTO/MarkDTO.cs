using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MarkDTO
    {
        string studentId;
        string testId;
        float grade;

        public MarkDTO(string studentId, string testId, float grade)
        {
            this.studentId = studentId;
            this.testId = testId;
            this.grade = grade;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string TestId { get => testId; set => testId = value; }
        public float Grade { get => grade; set => grade = value; }
    }
}
