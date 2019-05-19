using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClassLevelDTO
    {
        string classlevelId;
        string classlevelName;

        public ClassLevelDTO(string classlevelId, string classlevelName)
        {
            this.classlevelId = classlevelId;
            this.classlevelName = classlevelName;
        }

        public string ClassLevelId { get => classlevelId; set => classlevelId = value; }
        public string ClassLevelName { get => classlevelName; set => classlevelName = value; }
    }
}
