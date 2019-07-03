using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClassDTO
    {
        string classId;
        string className;
        string startHour;
        DateTime startDate;
        DateTime endDate;
        string programId;

        public ClassDTO(string classId, string className, string startHour, DateTime startDate, DateTime endDate, string programId)
        {
            this.classId = classId;
            this.className = className;
            this.startHour = startHour;
            this.startDate = startDate;
            this.endDate = endDate;
            this.programId = programId;
        }

        public string ClassId { get => classId; set => classId = value; }
        public string ClassName { get => className; set => className = value; }
        public string StartHour { get => startHour; set => startHour = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string ProgramId { get => programId; set => programId = value; }
    }
}
