using System;

namespace Params {
    class Program {
        static void Main() {
            People p1 = new People("fzm", 23);
            p1.putMessage();
            int[] ary = new int[] {10,20,30};
            p1.func(ary[0], ary[1], ary[2]);
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

        public void func(params int[] ary) {
            for(int i = 0; i < ary.Length; i++) {
                ary[i] += 100;
                Console.WriteLine("ary[{0}] = {1}", i, ary[i]);
            }
        }
    }
}