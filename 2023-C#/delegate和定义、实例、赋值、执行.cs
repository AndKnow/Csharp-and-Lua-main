using System;
using System.Reflection;

namespace Params {
    class Program {
        // 委托类型,只能在类里边,不能在函数里面
        // ref的作为参数类型的话,新值会传给下一个方法
        delegate void Mydel(ref int x);
        static void Main() {
            Father f = new Father();
            Child c  = new Child();
            // delegate的初始化,后面不能带参数
            Mydel del1 = f.fun2;
            del1 += Father.fun1;
            del1 += c.fun2;
            del1 += Child.fun3;
            // delegate的执行,把统一的参数放进去
            int x1 = 10, x2 = 20;
            del1(ref x1);
            // delegate的删除,从后面开始匹配,找到第一个适配的
            del1 += f.fun2;
            del1 += Father.fun1;
            del1 += c.fun2;
            del1 += Child.fun3;
            del1 -= Father.fun1;
            // 删除可能导致delegate的列表为空,需要做判断
            if(del1 != null) {
                del1(ref x2);//如果调用的结果带返回值,只会返回最后一个
            }
        }
    }

    class Father {
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
