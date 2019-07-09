using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        string user_Id;
        string user_name;
        string password;
        string department;

        public UserDTO(string user_id, string user_name, string password, string department)
        {
            this.user_Id = user_id;
            this.user_name = user_name;
            this.password = password;
            this.department = department;
        }

        public string User_Id { get => user_Id; set => user_Id = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Password { get => password; set => password = value; }
        public string Department { get => department; set => department = value; }
    }
}
