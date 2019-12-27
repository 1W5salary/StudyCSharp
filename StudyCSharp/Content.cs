using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    //观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
    //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
    public abstract class Content
    {
        public Content(){
            IsKind();
        }
        protected int Id;
        protected string Kind;
        public string Tittle { get; set; }
        public string Body { get; set; }
        protected int _reward;
        public int reward
        {
            get { return _reward; }
            set
            {
                if (value < 0)
                {
                    _reward = 0;
                }
                else
                {
                    _reward = value;
                }
            }
        }
        private DateTime CreateDateTime { get; set; }
        public DateTime PublishDateTime { get; }
        public User Author { get; set; }    
        public int BangMoney { get; set; }

        virtual public void Publish() { }
        virtual public void IsKind() { 
        }
    }
}
