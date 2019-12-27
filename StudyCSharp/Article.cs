using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    class Article:Content
    {
        public override void Publish()
        {
            Console.WriteLine("提交一个问题");
        }
        public override void IsKind()
        {
            Kind = "文章";
        }
    }
}
