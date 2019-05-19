using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class CourseBLL
    {
        public List<CourseDTO> GetAllCourse()
        {
            CourseDAL cdal = new CourseDAL();
            return cdal.GetAllCourse();
        }

        public List<CourseDTO> GetAllCourse(string course_id)
        {
            CourseDAL cdal = new CourseDAL();
            return cdal.GetAllCourse(course_id);
        }
        public CourseDTO GetCourse(string id)
        {
            CourseDAL cdal = new CourseDAL();
            return cdal.GetCourse(id);
        }

        public bool InsertCourse(CourseDTO course)
        {
            CourseDAL cdal = new CourseDAL();
            return cdal.InsertCourse(course);
        }

        public bool InsertCourse(string courseId, string courseYear)
        {
            CourseDAL cdal = new CourseDAL();
            return cdal.InsertCourse(courseId, courseYear);
        }

        public bool UpdateCourse(CourseDTO course)
        {
            CourseDAL cdal = new CourseDAL();
            return cdal.UpdateCourse(course);
        }
    }
}
