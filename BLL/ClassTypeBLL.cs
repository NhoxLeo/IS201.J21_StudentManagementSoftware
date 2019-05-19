using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ClassTypeBLL
    {
        public List<ClassTypeDTO> GetAllClassType()
        {
            ClassTypeDAL ctdal = new ClassTypeDAL();
            return ctdal.GetAllClassType();
        }

        public List<ClassTypeDTO> GetAllClassType(string classtype_id)
        {
            ClassTypeDAL ctdal = new ClassTypeDAL();
            return ctdal.GetAllClassType(classtype_id);
        }
        public ClassTypeDTO GetClassType(string id)
        {
            ClassTypeDAL ctdal = new ClassTypeDAL();
            return ctdal.GetClassType(id);
        }

        public bool InsertClassType(ClassTypeDTO classtype)
        {
            ClassTypeDAL ctdal = new ClassTypeDAL();
            return ctdal.InsertClassType(classtype);
        }

        public bool InsertClassType(string classtypeId, string classtypeName, DateTime startDate, int startingHour)
        {
            ClassTypeDAL ctdal = new ClassTypeDAL();
            return ctdal.InsertClassType(classtypeId, classtypeName, startDate, startingHour);
        }

        public bool UpdateClassType(ClassTypeDTO classtype)
        {
            ClassTypeDAL ctdal = new ClassTypeDAL();
            return ctdal.UpdateClassType(classtype);
        }
    }
}
