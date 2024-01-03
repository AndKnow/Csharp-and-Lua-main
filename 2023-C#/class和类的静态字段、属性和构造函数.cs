using System;

namespace Params {
    class Program {
        static void Main() {
            //类的静态字段、静态属性、静态构造函数
            Console.WriteLine("static Nums = {0}", People.nums);
            People.nums = 1000;
            Console.WriteLine("static Nums = {0}", People.nums);
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

        public string NetName {
            // 无后备字段时不能对属性进行处理
            set;
            get;
        }

        public People(string n, int a) {
            name = n;
            age = a;
            NetName = "unSet";
        }
        public void putMessage() {
            Console.WriteLine("Name = {0}, Age = {1}, Pass = {2}", name, age);
        }

    }
}