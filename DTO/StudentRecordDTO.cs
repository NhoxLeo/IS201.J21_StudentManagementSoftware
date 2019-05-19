using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentRecordDTO
    {
        string studentRecordId;
        int studentRecord;

        public StudentRecordDTO(string studentRecordId, int studentRecord)
        {
            this.studentRecordId = studentRecordId;
            this.studentRecord = studentRecord;
        }

        public string StudentRecordId { get => studentRecordId; set => studentRecordId = value; }
        public int StudentRecord { get => studentRecord; set => studentRecord = value; }
    }
}
