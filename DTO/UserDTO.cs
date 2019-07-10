using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        string userId;
        string userName;
        string password;
        string department;

        public UserDTO(string userId, string userName, string password, string department)
        {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.department = department;
        }

        public string UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Department { get => department; set => department = value; }
    }
}
