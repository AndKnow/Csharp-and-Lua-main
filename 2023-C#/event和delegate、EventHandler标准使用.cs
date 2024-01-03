using System;
using System.Reflection;

namespace Params {
    //delegate的声明,这是一个类型的声明,可以放在namespace,也可以放在class里面
    delegate void MyDEL(ref int x);
    class Program {
        static void Main() {
            Father.MyEVE += Father.fun1;//event可以直接添加方法,那这个和delegate差不多
            MyDEL mydel = Child.fun3;
            Father.MyEVE += mydel;//event可以直接添加整个delegate

            int x1 = 10;
            Father.trigger(ref x1);//event只能在被定义的class内部方法里面触发
        }
    }

    class Father {
        // event的声明：加个问号,把它变成可为空;和方法、属性一样，event是类或结构的成员
        // event的处理是异步的,不管程序在做什么,触发事件的时候都马上调用处理程序
        // 通常情况下使用过的delegate类型为EventHandler,函数参数为object 和 EventArgs
        static public event MyDEL ?MyEVE ; // 
        static public void trigger(ref int x) {
            if(MyEVE != null)
                MyEVE(ref x);
        }

        static public void fun1(ref int x) {
            Console.WriteLine("FatherClass Static Method : {0}", x++);
        }

        virtual public void fun2(ref int x) {
            Console.WriteLine("FatherClass Method : {0}", x++);
        }
    }
    
    class Child : Father {
        static public void fun3(ref int x) {
            Console.WriteLine("ChildClass Static Method : {0}", x++);
        }

        public override void fun2(ref int x)
        {
            Console.WriteLine("ChildClass Method : {0}", x++);
        }
    }
}
