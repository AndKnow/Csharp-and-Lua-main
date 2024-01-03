using System;

namespace Params {
    class Program {
        static void Main() {
            People p1 = new People("fzm", 23);
            p1.putMessage();
            int[] ary = new int[] {10,20,30};
            p1.func(n2:ary[0], n1:ary[2]);
            foreach(int n in ary) {
                Console.WriteLine("int main ary = {0}", n);
            }
        }

    }

    class People {
        public string name = "unKnown";
        public int age;

        public People(string n, int a) {
            name = n;
            age = a;
        }
        public void putMessage() {
            Console.WriteLine("Name = {0}, Age = {1}", name, age);
        }

        public void func(int n1 = 123, int n2 = 456, params int[] ary) {
            // 放进去的参数会优先填满和Params类型相同的可选参数
            Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2);
            for(int i = 0; i < ary.Length; i++) {
                ary[i] += 100;
                Console.WriteLine("ary[{0}] = {1}", i, ary[i]);
            }
        }
    }
}