using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    sealed public class User
    {
        //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        private int UserId { get; set; }

        //如果user.Name为“admin”，输入时修改为“系统管理员”
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value == "admin")
                {
                    _Name = "系统管理员";
                }
                else {
                    Name = value;
                }
            }
        }

        public string Password { private get; set; }
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
