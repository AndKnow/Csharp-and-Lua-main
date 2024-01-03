using System;

namespace Params {
    class Program {
        static void Main() {
            // 无法创建抽象类的实例
            ChildClass c = new ChildClass();
            c["first"] = "hello";
            c["last"]  = "world";
            Console.WriteLine(c["1"]);
            c.PutName();

        }
    }


    // 只有abstract的类才能拥有abstract类型的方法吗?但是此时无法创建实例
    abstract class FatherClass {
        // 抽象成员abstract只对方法、属性、索引器、事件有用,和virtual一样
        protected string firstName = "FatherFirstName";
        protected string lastName = "FatherLastName";

        abstract public string this[string index]{
            set;
            get;
        }

        abstract public void PutName();

    }
    // 单继承
    class ChildClass : FatherClass {
        override public string this [string index]{
            set {
                switch(index) {
                    case "first":firstName = value;break;
                    case "last" :lastName  = value;break;
                }
            } get {
                return firstName +" "+ lastName;
            }
        }

        public override void PutName()
        {
            Console.WriteLine("My Name is {0} {1}", firstName, lastName);
        }
    }
}
