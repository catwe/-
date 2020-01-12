using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承
{
    class Students : Person
    {
        public string Major { get; set; }
        public string Grade { get; set; }
        public new void Print()//隐藏父类的方法
        {
           // base.Print();//base调用父类中的方法
            Console.WriteLine("专业：" + Major);
            Console.WriteLine("年级：" + Grade);
        }
    }
}