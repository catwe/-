using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Person
    {
        public int Id { get; set; } //编号
        public string Name { get; set; }//姓名
        public string Sex { get; set; }//性别
        public string Cardid { get; set; }//身份证号
        public string Tel { get; set; }//联系方式

        /*
         * 重写和隐藏父类中的方法的区别：
         * 当使用对象时，隐藏 是调用的父类方法
         * 而重写 调用的是子类的方法
         */
        public virtual void Print() //添加Virtual关键字表示该方法在之后会被重写
        {
            Console.WriteLine("编号：" + Id);
            Console.WriteLine("姓名：" + Name);
            Console.WriteLine("性别：" + Sex);
            Console.WriteLine("身份证号：" + Cardid);
            Console.WriteLine("联系方式：" + Tel);
        }
    }
}
