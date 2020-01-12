using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承
{
    class MathMajor : ExamResult
    {
        public override void Total()
        {
            double total = Math * 0.6 + English * 0.4;
            Console.WriteLine("学号为" + Id + "数学专业学生的成绩为：" + total);
        }
    }
}