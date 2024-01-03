using System;

namespace Params {
    class Program {
        static void Main() {
            ChildClass c = new ChildClass("ABC", "DEF");
            c.func();
        }
    }

    class FatherClass {
        public string firstName = "FatherFirstName";
        public string lastName = "FatherLastName";
        public FatherClass(string s1) {
            firstName = s1;
        }

        virtual public void func() {
            Console.WriteLine("func Father's name is [{0}]", firstName + " " + lastName);
        }

    }
    // 单继承
    class ChildClass : FatherClass {
        public string NewfirstName = "ChildFirstName";
        public string NewlastName = "ChildLastName";
        new public string lastName = "OldChildLastName";
        
        public ChildClass() : base("I don't know") {
            NewfirstName = "hello";
            NewlastName  = "world";
        }

        public ChildClass(string s1, string s2) : this() {
            NewlastName = s2;
        }

        override public void func() {
            Console.WriteLine("func Child's name is [{0}]", firstName + " " + lastName);
            Console.WriteLine("func Child's name is [{0}]", NewfirstName + " " + NewlastName);
        }
    }
}
