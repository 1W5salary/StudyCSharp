using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    public class Problem
    {
        //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author）
        //和方法Publish()
        private string Tittle { get; set; }
        private string Body { get; set; }
        private int reward { get; set; }
        private DateTime PublishDateTime { get; set; }
        private User Author { get; set; }

        public void Publish() { 
            
        }
    }
}
