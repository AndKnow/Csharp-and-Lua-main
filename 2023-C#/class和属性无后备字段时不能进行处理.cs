using System;

namespace Params {
    class Program {
        static void Main() {
            People p1 = new People("fzm", 23);
            p1.NetName = "AndKnow";
            Console.WriteLine("fzm's NetName = {0}", p1.NetName);
        }

    }

    class People {
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