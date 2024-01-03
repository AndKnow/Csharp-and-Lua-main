using System;
using System.Reflection;

namespace Params {
    // 泛型委托的定义
    delegate T Mydel<T,R> (R x);
    class Program {
        static void Main() {
            // 泛型类的实例化
            MyClass<string> c1 = new MyClass<string>();
            string s = c1.func("hello world");
            Console.WriteLine(s);
            // 泛型方法的使用
            MyClass<int>.func2<string>("hi hi hi~");
            MyClass<string>.func3("la la la ~");

            // 泛型委托的调用
            Mydel<int, string> mydel = MyClass<string>.func3;
            mydel("China");

            // 泛型借口的继承和实现
            MyInt<int> myint = new MyClass2<int>();
            myint.intFunc(99);

        }
    }

    // 泛型类的定义,where约束
    class MyClass <T> where T:IComparable {
        public T [] ?ary = null;
        public T func(T x) {
            return x;
        }

        // 泛型方法
        static public string func2<S> (S x) {
            Console.WriteLine("func2 " + x);
            return "hello";
        }

        static public int func3(T x) {
            Console.WriteLine("func3 " + x);   
            return 100;
        }
    }

    interface MyInt<T> {
        void intFunc(T x);
    }

    class MyClass2<T>:MyInt<T> {
        public void intFunc(T x) {
            Console.WriteLine("myclass2 interface func : {0}", x);
        }
    }

}
