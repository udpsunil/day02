using System;

namespace day02
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new ClassExample();
            var class2 = new day02new.ClassExample();
            class1.Display();
            class2.Display();
        }
    }

    public class ClassExample
    {
        public void Display()
        {
            Console.WriteLine("This is a class 'ClassExample' of namespace 'day02'.");
        }
    }
}

namespace day02new
{
    public class ClassExample
    {
        public void Display()
        {
            Console.WriteLine("This is a class 'ClassExample' of namespace 'day02new'.");
        }
    }
}
