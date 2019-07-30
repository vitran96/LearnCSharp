using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Time for some class/object testing!!");
            Console.WriteLine("Why the fuck does will have to have a Main function? that sound so fucking wrong");
            var testClass = new TestClass();
            testClass.show();
        }
    }

    class TestClass
    {
        public TestClass()
        {
            // None
        }

        public void show()
        {
            Console.WriteLine("This is a test!");
        }
    }
}
