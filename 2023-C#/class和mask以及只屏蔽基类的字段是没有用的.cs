using System;

namespace Params {
    class Program {
        static void Main() {
            // clss和单继承、屏蔽基类成员、屏蔽静态成员
            // 为了修改字段的初始化和修改方法的意义
            FatherClass f = new FatherClass();
            f.func();
            ChildClass c = new ChildClass();
            // 只屏蔽的基类的字段并没有什么用,因为继承下来
            // 的积累方法指向的仍然是基类的字段
            c.func();
            c.func2();
        }
    }

    class FatherClass {
        public string firstName = "FatherFirstName";
        public string lastName = "FatherLastName";

        public void func() {
            Console.WriteLine("Father's name is [{0}]", firstName + " " + lastName);
        }
        public void func2() {
            Console.WriteLine("Father's name is [{0}]", firstName + " " + lastName);
        }
    }
    // 单继承
    class ChildClass : FatherClass {
        new public string firstName = "ChildFirstName";
        new public string lastName = "ChildLastName";
    }
}