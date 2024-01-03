using System;
using System.Reflection;

namespace Params {
    class Program {
        enum Season:uint {
            //enum,不能在函数体内定义,只能在类里面定义
            spring = 1,
            summer = 3,
            fall,
            winter,
        }
        static void Main() {
            //Enum getname从位置1开始,以及GetNames的使用
            Console.WriteLine("Name = {0}", Enum.GetName(typeof(Season), 1));
            foreach(string name in Enum.GetNames(typeof(Season))) {
                Console.WriteLine(name);
            }
        }
    }
}
