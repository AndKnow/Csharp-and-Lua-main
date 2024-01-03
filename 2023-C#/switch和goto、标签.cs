using System;
using System.Reflection;

namespace Params {
    class Program {

        static void Main() {
            // switch和跳转语句,continue、goto、return、throw;
            int key = 5;
            switch(key) {
                case 1:
                case 2:
                case 5:Console.WriteLine("hello world");goto default;
                default:Console.WriteLine("default");goto field1;
            }
            // 标签
            field1:{
                Console.WriteLine("in field");
            }
            Console.WriteLine("after field");
        }
    }
}
