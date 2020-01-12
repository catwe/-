using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承
{
    class EnglishMajor : ExamResult
    {
        public override void Total()
        {
            double total = Math * 0.4 + English * 0.6;
            Console.WriteLine("学号为" + Id + "英语专业学生的成绩为：" + total);
        }
    }
}