using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    class ClassBLL
    {
        public List<ClassDTO> GetAllClass()
        {
            ClassDAL cdal = new ClassDAL();
            return cdal.GetAllClass();
        }

        public List<ClassDTO> GetAllClass(string class_id)
        {
            ClassDAL cdal = new ClassDAL();
            return cdal.GetAllClass(class_id);
        }
        public ClassDTO GetClass(string id)
        {
            ClassDAL cdal = new ClassDAL();
            return cdal.GetClass(id);
        }

        public bool InsertClass(ClassDTO _class)
        {
            ClassDAL cdal = new ClassDAL();
            return cdal.InsertClass(_class);
        }

        public bool InsertClass(string _classId, string _className, int _classCount)
        {
            ClassDAL cdal = new ClassDAL();
            return cdal.InsertClass(_classId, _className, _classCount);
        }

        public bool UpdateClass(ClassDTO _class)
        {
            ClassDAL cdal = new ClassDAL();
            return cdal.UpdateClass(_class);
        }
    }
}
