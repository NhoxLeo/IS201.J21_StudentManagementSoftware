using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PotentialStudentDTO
    {
        string potentialstudentId;
        string potentialstudentName;
        float mark;
        string phone;
        int dateCount;
        string status;
        string address;
        string gender;
        public PotentialStudentDTO(string potentialstudentId, string potentialstudentName, float mark, string phone,int dateCount,string status,string address, string gender)
        {
            this.potentialstudentId = potentialstudentId;
            this.potentialstudentName = potentialstudentName;
            this.mark = mark;
            this.phone = phone;
            this.dateCount = dateCount;
            this.status = status;
            this.address = address;
            this.gender = gender;
        }

        public string PotentialStudentId { get => potentialstudentId; set => potentialstudentId = value; }
        public string PotentialStudentName { get => potentialstudentName; set => potentialstudentName = value; }
        public float Mark { get => mark; set => mark = value; }
        public string Phone { get => phone; set => phone = value; }
        public int DateCount { get => dateCount; set => dateCount = value; }
        public string Status { get => status; set => status = value; }
        public string Address { get => address; set => status = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
