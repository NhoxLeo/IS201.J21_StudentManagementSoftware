using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TestDTO
    {
        string testId;
        string classId;
        DateTime testDate;
        string testHour;

        public TestDTO(string testId,string classId, DateTime testDate,string testHour)
        {
            this.testId = testId;
            this.classId = classId;
            this.testDate = testDate;
            this.testHour = testHour;
        }

        public string TestId { get => testId; set => testId = value; }
        public string ClassId { get => classId; set => classId = value; }
        public DateTime TestDate { get => testDate; set => testDate = value; }
        public string TestHour { get => testHour; set => testHour = value; }
    }
}
