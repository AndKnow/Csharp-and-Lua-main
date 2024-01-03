using System;

namespace Params {
    class Program {
        static void Main() {
            // clss和单继承、屏蔽基类成员、屏蔽静态成员
            // 为了修改字段的初始化和修改方法的意义
            FatherClass f = new FatherClass();
            f.func();
            ChildClass c = new ChildClass();
            c.func();
        }
    }

    class FatherClass {
        public string firstName = "FatherFirstName";
        public string lastName = "FatherLastName";

        public void func() {
            Console.WriteLine("Father's name is [{0}]", firstName + " " + lastName);
        }
    }
    // 单继承
    class ChildClass : FatherClass {
        new public string firstName = "ChildFirstName";
        new public string lastName = "ChildLastName";
        // 覆盖属性和覆盖函数
        new public void func() {
            base.firstName = "hello"; base.lastName = "world";
            Console.WriteLine("Child's name is [{0}]", firstName + " " + base.lastName);
            // 强制访问基类的方法,里面的字段也是基类原来的初始化字段
            // 所以原理上不是覆盖,而是把基类的字段隐藏起来,自己重新创建一个
            base.func();
        }
    }
}