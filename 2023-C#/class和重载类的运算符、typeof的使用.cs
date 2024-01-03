using System;
using System.Reflection;

namespace Params {
    class Program {

        static void Main() {
            FatherClass  f1 = new FatherClass() {firstName = "hello"};
            FatherClass  f2 = new FatherClass() {lastName = "world"};
            FatherClass f = new FatherClass();
            f = f1 + f2;
            f.PutName();
            // typeof的使用,using System.Reflection
            Type t = typeof(FatherClass);
            FieldInfo[] fi  = t.GetFields();
            MethodInfo[] mi = t.GetMethods();
            foreach(FieldInfo i in fi) {
                Console .WriteLine("fieldinfo : {0}", i.Name);
            } 
            foreach(MethodInfo i in mi) {
                Console.WriteLine("Methodinfo : {0}", i.Name);
            }

        }
    }

    class FatherClass {
        // 抽象成员abstract只对方法、属性、索引器、事件有用,和virtual一样
        public string firstName = "FatherFirstName";
        public string lastName = "FatherLastName";

        public static FatherClass operator + (FatherClass f1, FatherClass f2) {
            FatherClass f = new FatherClass() {firstName = f1.firstName, lastName = f2.lastName};
            return f;
        }

        virtual public void PutName()
        {
            Console.WriteLine("My Name is {0} {1}", firstName, lastName);
        }

    }
    // 单继承
    class ChildClass : FatherClass {

        public override void PutName()
        {
            Console.WriteLine("My Name is {0} {1}", firstName, lastName);
        }
    }
}
