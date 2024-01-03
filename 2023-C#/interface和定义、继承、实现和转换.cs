using System;
using System.Reflection;

namespace Params {
    class Program {
        static void Main() {
            Child c = new Child();
            Son s = new Son();
            People1 p1 = s;
            p1.Method1();
            People2 p2 = c;
            p2.Method1();
            
            
        }
    }
    //接口声明不能包含以下成员∶数据成员、静态成员
    //只能包含非静态函数：方法、属性、事件、索引器
    interface People1 {
        void Method1();
    }

    interface People2 {
        void Method1();
    }
    
    // 如果类实现了接口，它必须实现接口的所有成员;类可以继承任意多个接口
    // 如果类从基类继承并实现了接口，基类列表中的基类名称必须放在所有接口之前
    class Child : People1, People2 {
        void People1.Method1() {
            Console.WriteLine("People1 Child Method1");
        }
        
        void People2.Method1() {
            Console.WriteLine("People2 Child Method1");
        }

    }

    // 实现接口的类可以从它的基类继承实现的代码
    class Son : Child {

    } 
}
