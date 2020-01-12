using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    /*
     创建一个类，测试object中Equals方法
         */

   
    class Program
    {
        static void Main(string[] args)
        {
            //创建两个对象，测试是否属于同一个对象（Equals静态方法）

            Person stu1 = new Students();//用父类定义的，但是调用的是还是父类，因为是隐藏
            Students stu2 = new Students();

            bool result = Equals(stu1, stu2);
            Console.Write("这两个对象属于同一个对象：" + result+"\n");//false

            //Equals非静态方法
            Console.WriteLine("这两个对象属于同一个对象：" + stu1.Equals(stu2));//false


            /*
             测试GetHashCode方法
             */
            Console.WriteLine("stu1的HashCode为：" + stu1.GetHashCode());
            Console.WriteLine("stu2的HashCode为：" + stu2.GetHashCode());

            /*
             测试GetType方法
             */
            int i = 100;
            string name = "王聪";
            Console.WriteLine(i + "  "+"的数值类型为：" + i.GetType());
            Console.WriteLine(name + "  " + "的数值类型为：" + name.GetType());
            Console.WriteLine(stu1 + "  " + "的数值类型为：" + stu1.GetType());

            /*
             测试ToString方法
             */
            Console.WriteLine(stu1 + "  " + "的ToString后为：" + stu1.ToString());
            Console.WriteLine(i + "  " + "的ToString后为：" + i.ToString());
            Console.WriteLine(name + "  " + "的ToString后为：" + name.ToString());
           


            /*
             测试继承
             */
            stu1.Id = 2016212806;
            stu1.Name = "王聪";
            stu1.Sex = "男";
            stu1.Cardid = "500235199711014012";
            //stu1.Grade = "大四";
            stu1.Tel = "185813862096";
            //stu1.Major = "电气工程及其自动化";
            stu1.Print();

            Person teacher = new Teacher();//用父类定义调用的还是子类，因为是重写
            teacher.Id = 500235;
            teacher.Name = "王老师";
            teacher.Print();//如果没有用base关键字，就只会出现子类中方法的结果

            /*
             测试abstract抽象类
             */
            MathMajor mathMajor = new MathMajor();
            mathMajor.Id = 1;
            mathMajor.English = 80;
            mathMajor.Math = 90;
            mathMajor.Total();
            EnglishMajor englishMajor = new EnglishMajor();
            englishMajor.Id = 2;
            englishMajor.English = 80;
            englishMajor.Math = 90;
            englishMajor.Total();



            Console.ReadLine();
        }
    }
}
