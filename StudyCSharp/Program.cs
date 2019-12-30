using System;
using System.Data.SqlClient;

namespace StudyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.控制台读取用户输入,转换成int类型
            //2.根据score生成等级
            //3.根据等级输出输出评语
            try
            {
                getRemark(getGrade(getSorce()));
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("你输入成绩的超出范围");
                getRemark(getGrade(getSorce()));
            }
            catch (Exception)
            {
                Console.WriteLine("你输入成绩不是int");
                getRemark(getGrade(getSorce()));

            }
            
        }




        static Grade getGrade(int score) {
            if (score>100||score<0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (score > 80) 
            {
                return Grade.Excellent;
            }
            if (score>60)
            {
                return Grade.Passed;
            }
            else
            {
                return Grade.Failed;
            }
        }

        static void getRemark(Grade grade) {
            switch (grade)
            {
                case Grade.Excellent:
                    Console.WriteLine("真厉害");
                    break;
                case Grade.Passed:
                    Console.WriteLine("不错");
                    break;
                case Grade.Failed:
                    Console.WriteLine("抱歉你没通过");
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"出现了未出现的{grade}");
            }
        }

        static int getSorce()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        enum Grade { 
            Excellent,
            Passed,
            Failed
        }

    }
}