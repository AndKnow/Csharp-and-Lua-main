using System;

namespace Params {
    class Program {
        static void Main() {
            //类的静态字段、静态属性、静态构造函数
            People p1 = new People("hello", 123);
            People p2 = new People("world", 456) {age = 789};
            p1.putMessage();
            p2.putMessage();
        }

    }

    class People {
        // 静态字段和属性
        private static int Nums;
        static public int nums{
            set {
                Nums = value;
            }
            get {
                return Nums;
            }
        }
        // 静态构造函数
        static People() {
            Nums = 999;
        }
        public string name = "unKnown";
        public int age;


        public People(string n, int a) {
            name = n;
            age = a;
        }
        public void putMessage() {
            Console.WriteLine("Name = {0}, Age = {1}", name, age);
        }

    }
}