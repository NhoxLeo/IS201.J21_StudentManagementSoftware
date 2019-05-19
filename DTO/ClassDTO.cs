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
        int classCount;

        public ClassDTO(string classId,string className, int classCount)
        {
            this.classId = classId;
            this.className = className;
            this.classCount = classCount;
        }

        public string ClassId { get => classId; set => classId = value; }
        public string ClassName { get => className; set => className = value; }
        public int ClassCount { get => classCount; set => classCount = value; }
    }
}
