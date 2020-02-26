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

            // 'As' identifier example. 
            var stakeholder = new as_example.Stakeholder();
            var person = new as_example.Author();
            person.Name = "Sunil Udupi";
            stakeholder.GetAuthorName(person);
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

namespace as_example
{
    public class Stakeholder
    {
        public void GetAuthorName(Person person)
        {
            var authorname = person as Author;
            Console.WriteLine(authorname != null ? $"Author is {authorname.Name}" : "No Author");
        }
    }

    internal class Author:Person
    {
    }

    public class Person
    {
        public String Name;
    }
}
