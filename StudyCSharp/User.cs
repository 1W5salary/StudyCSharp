using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    public class User
    {
        //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        private int UserId { get; set; }

        //如果user.Name为“admin”，输入时修改为“系统管理员”
        private string _UserName;
        private string UserName
        {
            get { return _UserName; }
            set
            {
                if (value == "admin")
                {
                    _UserName = "系统管理员";
                }
                else {
                    _UserName = value;
                }
            }
        }
        //user.Password在类的外部只能改不能读
        private string _Password;
        public string Password
        {
            private get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
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
