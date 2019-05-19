using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CourseDTO
    {
        string courseId;
        DateTime courseYear;

        public CourseDTO(string courseId, DateTime courseYear)
        {
            this.courseId = courseId;
            this.courseYear = courseYear;
        }

        public string CourseId { get => courseId; set => courseId = value; }
        public DateTime CourseYear { get => courseYear; set => courseYear = value; }
    }
}
