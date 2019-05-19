using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TestBLL
    {
        public List<TestDTO> GetAllTest()
        {
            TestDAL tdal = new TestDAL();
            return tdal.GetAllTest();
        }

        public List<TestDTO> GetAllTest(string test_id)
        {
            TestDAL tdal = new TestDAL();
            return tdal.GetAllTest(test_id);
        }
        public TestDTO GetTest(string id)
        {
            TestDAL tdal = new TestDAL();
            return tdal.GetTest(id);
        }

        public bool InsertTest(TestDTO test)
        {
            TestDAL tdal = new TestDAL();
            return tdal.InsertTest(test);
        }

        public bool InsertTest(string testId, DateTime testDate)
        {
            TestDAL tdal = new TestDAL();
            return tdal.InsertTest(testId, testDate);
        }

        public bool UpdateTest(TestDTO test)
        {
            TestDAL tdal = new TestDAL();
            return tdal.UpdateTest(test);
        }
    }
}
