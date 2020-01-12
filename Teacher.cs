using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承
{
    class Teacher : Person
    {
        public string Title { get; set; }
        public string WageNo { get; set; }
        public override void Print()//重写父类中的方法
        {
            //base.Print();//不需要这个也可以使用父类的参数
            Console.WriteLine("职称：" + Title);
            Console.WriteLine("工资号：" + WageNo);
        }
    }
}