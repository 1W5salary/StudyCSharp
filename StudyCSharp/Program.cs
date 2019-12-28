using System;

namespace StudyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "源栈";
            string b = "，";
            string c = "欢迎您!";

            //直接把abc连接起来
            Console.WriteLine(string.Concat(a, b, c));
            //把abc用' '连接起来
            string joined = string.Join(' ', a, b, c);
            Console.WriteLine(joined);   //注意空格：源栈 ， 欢迎您!
        }
    }
}
