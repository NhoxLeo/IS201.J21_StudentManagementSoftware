using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ClassLevelBLL
    {
        public List<ClassLevelDTO> GetAllClassLevel()
        {
            ClassLevelDAL cldal = new ClassLevelDAL();
            return cldal.GetAllClassLevel();
        }

        public List<ClassLevelDTO> GetAllClassLevel(string classlevel_id)
        {
            ClassLevelDAL cldal = new ClassLevelDAL();
            return cldal.GetAllClassLevel(classlevel_id);
        }
        public ClassLevelDTO GetClassLevel(string id)
        {
            ClassLevelDAL cldal = new ClassLevelDAL();
            return cldal.GetClassLevel(id);
        }

        public bool InsertClassLevel(ClassLevelDTO classlevel)
        {
            ClassLevelDAL cldal = new ClassLevelDAL();
            return cldal.InsertClassLevel(classlevel);
        }

        public bool InsertClassLevel(string classlevelId, string classlevelName)
        {
            ClassLevelDAL cldal = new ClassLevelDAL();
            return cldal.InsertClassLevel(classlevelId, classlevelName);
        }

        public bool UpdateClassLevel(ClassLevelDTO classlevel)
        {
            ClassLevelDAL cldal = new ClassLevelDAL();
            return cldal.UpdateClassLevel(classlevel);
        }
    }
}
