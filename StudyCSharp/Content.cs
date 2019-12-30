using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    //观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
    //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
    public abstract class Content : Agree
    {
        //内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
        public Content(User user)
        {
            if (user==null)
            {
                throw new ArgumentNullException();
            }
            Author = user;
            IsKind();
        }

        protected int Id;
        protected string Kind;
        public string _Tittle;

        public string Tittle
        {
            get { return _Tittle = Tittle; }
            set {
                value.Trim();
                if (value == null) {
                    Console.WriteLine("标题不能为空");
                }
                _Tittle = value;
            }
        }
        public string Body { get; set; }
        protected int _reward;
        //修改之前的属性验证：problem.Reward为负数时直接抛出“参数越界”异常
        public int reward
        {
            get { return _reward; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
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
        public int Agree { get; set; }




        virtual public void IsKind()
        {
        }
        virtual public void Publish()
        {

        }

        public void AddAgree()
        {
            Agree++;
            Author.HelpNum++;
        }

        public void Disagree()
        {
            Agree--;
            Author.HelpNum--;
        }
    }
}
