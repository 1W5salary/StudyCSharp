using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    class Suggest:Content
    {
        public override void Publish()
        {
            Console.WriteLine("提交一个建议");
        }


        public override void IsKind()
        {
            Kind = "建议";

        }
    }
}
