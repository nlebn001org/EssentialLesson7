using System;

namespace EssentialLesson7Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass cl = new MyClass(); 
            MyStruct st = new MyStruct();

            cl.change = "Not changed";
            st.change = "Not changed";

            Console.WriteLine(cl.change);
            Console.WriteLine(st.change);
            Console.WriteLine();

            ClassTaker(cl);
            StruktTaker(st);

            Console.WriteLine(cl.change);
            Console.WriteLine(st.change);

        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Changed";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Changed";
        }
    }
}
