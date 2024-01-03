using System;

namespace Params {
    class Program {
        static void Main() {
            //类的静态字段、静态属性、静态构造函数
            People p1 = new People("hello", 123);
            People p2 = new People("world", 456) {age = 789};
            p1[1] = "1s1";p1["index2"] = "indexs2";
            Console.WriteLine("{0}", p1[0]);
        }

    }

    class People {
        private string s1 = "s1";
        private string s2 = "s2";
        // 索引器构建
        public string this [int index] {
            set {
                switch(index){
                    case 1:s1 = value; break;
                    case 2:s2 = value; break;
                }
            }
            get {
                return s1 + "  " + s2;
            }
        }
        // 索引器重载
        public string this [string index] {
            set {
                switch(index){
                    case "index1":s1 = value; break;
                    case "index2":s2 = value; break;
                }
            }
            get {
                return s1 + "  " + s2;
            }
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