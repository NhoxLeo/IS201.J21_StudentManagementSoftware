using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReserveStudentDTO
    {
        string reservestudentId;
        string reservestudentName;
        float mark;
        string phone;
        int dateCount;
        string status;

        public ReserveStudentDTO(string reservestudentId, string reservestudentName, float mark, string phone,int dateCount,string status)
        {
            this.reservestudentId = reservestudentId;
            this.reservestudentName = reservestudentName;
            this.mark = mark;
            this.phone = phone;
            this.dateCount = dateCount;
            this.status = status;
        }

        public string ReserveStudentId { get => reservestudentId; set => reservestudentId = value; }
        public string ReserveStudentName { get => reservestudentName; set => reservestudentName = value; }
        public float Mark { get => mark; set => mark = value; }
        public string Phone { get => phone; set => phone = value; }
        public int DateCount { get => dateCount; set => dateCount = value; }
        public string Status { get => status; set => status = value; }
    }
}
