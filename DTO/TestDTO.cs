using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TestDTO
    {
        string testId;
        DateTime testDate;

        public TestDTO(string testId, DateTime testDate)
        {
            this.testId = testId;
            this.testDate = testDate;
        }

        public string TestId { get => testId; set => testId = value; }
        public DateTime TestDate { get => testDate; set => testDate = value; }
    }
}
