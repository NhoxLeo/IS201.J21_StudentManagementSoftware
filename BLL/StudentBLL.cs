using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class StudentBLL
    {
        public List<StudentDTO> GetAllStudent()
        {
            StudentDAL sdal = new StudentDAL();
            return sdal.GetAllStudent();
        }

        public List<StudentDTO> GetAllStudent(string student_id)
        {
            StudentDAL sdal = new StudentDAL();
            return sdal.GetAllStudent(student_id);
        }
        public StudentDTO GetStudent(string id)
        {
            StudentDAL sdal = new StudentDAL();
            return sdal.GetStudent(id);
        }

        public bool InsertStudent(StudentDTO student)
        {
            StudentDAL sdal = new StudentDAL();
            return sdal.InsertStudent(student);
        }

        public bool InsertStudent(string studentId, string studentName, string studentAddress)
        {
            StudentDAL sdal = new StudentDAL();
            return sdal.InsertStudent(studentId, studentName, studentAddress);
        }

        public bool UpdateStudent(StudentDTO student)
        {
            StudentDAL sdal = new StudentDAL();
            return sdal.UpdateStudent(student);
        }
    }
}
