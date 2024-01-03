using System;

namespace Params {
    class Program {
        static void Main() {
            People p1 = new People("fzm", 23);
            p1.putMessage();
            p1.FakePass = "654789";
            Console.WriteLine("fzm's pass = {0}", p1.FakePass);
            p1.putMessage();
        }

    }

    class People {
        public string name = "unKnown";
        public int age;
        private string RealPass;
        // 属性
        public string FakePass {
            set {
                RealPass = value;
            }
            get {
                return "You cannot access";
            }
        } 

        public People(string n, int a) {
            name = n;
            age = a;
            RealPass = "Unset";
        }
        public void putMessage() {
            Console.WriteLine("Name = {0}, Age = {1}, Pass = {2}", name, age, RealPass);
        }

    }
}