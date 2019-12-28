using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    public class Stack
    {
        private int top;
        public object[] container;

        public Stack(int lendgth)
        {
            top = 0;
            container = new object[lendgth];
        }

        //按进
        public void Push(params object[] element)
        {
            if (top >= element.Length)
            {
                Console.WriteLine("插入的数量大于了栈的空余位置");
                return;
            }
            for (int i = 0; i < element.Length; i++)
            {
                container[top] = element[i];
                top++;
            }
        }

        //弹出
        public void Pop()
        {
            if (top <= 0)
            {
                Console.WriteLine("栈空了，弹不出去了");
            }
            top--;
            container[top] = null;
            
        }
    }
}
