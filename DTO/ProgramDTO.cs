using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProgramDTO
    {
        string programId;
        string programName;
        int level;
        int fee;

        public ProgramDTO(string programId, string programName, int level, int fee)
        {
            this.programId = programId;
            this.programName = programName;
            this.level = level;
            this.fee = fee;
        }

        public string ProgramId { get => programId; set => programId = value; }
        public string ProgramName { get => programName; set => programName = value; }
        public int Level { get => level; set => level = value; }
        public int Fee { get => fee; set => fee = value; }
    }
}
