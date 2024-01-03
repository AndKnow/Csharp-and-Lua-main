using System;

namespace Simple
{
    class Program {
        static void f(params int[] ary) {
            for(int i = 0; i < ary.Length; i++) {
                ary[i] += 100;
                Console.WriteLine("F {0} = {1}", i, ary[i]);
            }
        }
        static void Main() {
            int[] ary = new int[] {10,20,30};
            f(ary);
            foreach(int n in ary) {
                Console.WriteLine("main {0}", n);
            }
        }
    }
}