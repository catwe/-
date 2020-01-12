using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承
{
    abstract class ExamResult
    {
        //学号
        public int Id { get; set; }
        //数学成绩
        public double Math { get; set; }
        //英语成绩
        public double English { get; set; }
        //计算总成绩
        public abstract void Total();
    }
}