using System;

namespace Params {
    class Program {

        static void Main() {
            FatherClass  fc = new FatherClass();
            // 定义implicit之后,显式和隐式转换都能用;
            // 定义explicit之后,只有显式转换能使用
            string str = fc;
            string str1 = (string)fc;
            Console.WriteLine("string = {0}, {1}", str, str1);
        }
    }

    class FatherClass {
        public string firstName = "FatherFirstName";
        public string lastName = "FatherLastName";
        static public implicit operator string(FatherClass fc) {
            return fc.firstName + " " + fc.lastName;
        }

        virtual public void PutName()
        {
            Console.WriteLine("My Name is {0} {1}", firstName, lastName);
        }

    }
    // 单继承
    class ChildClass : FatherClass {

        public override void PutName()
        {
            Console.WriteLine("My Name is {0} {1}", firstName, lastName);
        }
    }
}
