using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    class EmailMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("发送邮件消息");
        }
    }
}
