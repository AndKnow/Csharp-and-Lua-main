using System;

namespace Params {
    class Program {
        static void Main() {
            FatherClass f = new ChildClass();
            ChildClass  c = new ChildClass();
            f.func();//基类的引用+override,所以一直找到虚函数,并且调用派生的那一层方法和字段
            f.func2();//基类的引用,但是没有override,所以不会向下寻找,直接执行基类的方法
            c.func();//一个派生类对象+override,没有疑义的执行派生类的方法以及访问自身字段
            c.func2();//派生类对象+new,因为new了方法,所以方法里面访问的是自身的字段,不是new的话就访问基类字段
        }
    }

    class FatherClass {
        public string firstName = "FatherFirstName";
        public string lastName = "FatherLastName";

        virtual public void func() {
            Console.WriteLine("func Father's name is [{0}]", firstName + " " + lastName);
        }
        virtual public void func2() {
            Console.WriteLine("func2 Father's name is [{0}]", firstName + " " + lastName);
        }
    }
    // 单继承
    class ChildClass : FatherClass {
        new public string firstName = "ChildFirstName";
        new public string lastName = "ChildLastName";

        override public void func() {
            Console.WriteLine("func Child's name is [{0}]", firstName + " " + lastName);
        }

        new public void func2() {
            Console.WriteLine("func2 Child's name is [{0}]", firstName + " " + lastName);
        }
    }
}