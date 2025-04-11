using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickmimo.Entities
{
    public class UserSession
    {
        public static User connectedUser { get; set; }

        public UserSession(User user) { 
            connectedUser = user;
        }

    }
}
