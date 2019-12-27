using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    public class Problem : Content
    {
        //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author）
        //和方法Publish()
        public Problem(int reward)
        {
            IsKind();
            this.reward = reward;
        }

        public override void Publish()
        {
            Console.WriteLine("提交一个问题");
        }
        public override void IsKind()
        {
            Kind="问题";
        }
    }
}
