using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class StudentRecordBLL
    {
        public List<StudentRecordDTO> GetAllStudentRecord()
        {
            StudentRecordDAL bdal = new StudentRecordDAL();
            return bdal.GetAllStudentRecord();
        }

        public List<StudentRecordDTO> GetAllStudentRecord(string studentrecord_id)
        {
            StudentRecordDAL bdal = new StudentRecordDAL();
            return bdal.GetAllStudentRecord(studentrecord_id);
        }
        public StudentRecordDTO GetStudentRecord(string id)
        {
            StudentRecordDAL bdal = new StudentRecordDAL();
            return bdal.GetStudentRecord(id);
        }

        public bool InsertStudentRecord(StudentRecordDTO studentrecord)
        {
            StudentRecordDAL bdal = new StudentRecordDAL();
            return bdal.InsertStudentRecord(studentrecord);
        }

        public bool InsertStudentRecord(string studentrecordId, int studentRecord)
        {
            StudentRecordDAL bdal = new StudentRecordDAL();
            return bdal.InsertStudentRecord(studentrecordId, studentRecord);
        }

        public bool UpdateStudentRecord(StudentRecordDTO studentrecord)
        {
            StudentRecordDAL bdal = new StudentRecordDAL();
            return bdal.UpdateStudentRecord(studentrecord);
        }
    }
}
