using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    public class User
    {
        private int UserId { get; set; }
        string UserName { get; set; }
        string password { get; set; }
        User InvitedBy { get; set; }

        public void Register(User user)
        {
        }

        public User Login(User user)
        {
            return null;
        }
    }
}
