using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("与数据库通信");
        }
    }
}
