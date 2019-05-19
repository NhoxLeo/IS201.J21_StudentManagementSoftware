using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ClassTypeDTO
    {
        string classtypeId;
        string classtypeName;
        DateTime startDate;
        int startingHour;

        public ClassTypeDTO(string classtypeId, string classtypeName, DateTime startDate,int startingHour)
        {
            this.classtypeId = classtypeId;
            this.classtypeName = classtypeName;
            this.startDate = startDate;
            this.startingHour = startingHour;
        }

        public string ClassTypeId { get => classtypeId; set => classtypeId = value; }
        public string ClassTypeName { get => classtypeName; set => classtypeName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public int StartingHour { get => startingHour; set => startingHour = value; }
    }
}
