using System;

namespace oop
{
    public class staticConstructor
    {
        static staticConstructor()
        {
            Console.WriteLine("static Constructor called !");
        }
        public staticConstructor()
        {
            Console.WriteLine("public Constructor Invoked !");
        }
        public static void sample()
        {
            Console.WriteLine("Sample Static Method called !");

        }
    }
    public class Singleton
    {
        // Static field initializer calls instance constructor.
        private static Singleton instance = new Singleton();

        private Singleton()
        {
            Console.WriteLine("Executes before static constructor. private constructor");
        }

        static Singleton()
        {
            Console.WriteLine("Executes after instance constructor. static constructor");
        }
        public static Singleton Instance => instance;
    }

    public class Singleton1
    {
        public static Singleton1 obj1 = new Singleton1();
        public Singleton1()
        {
            Console.WriteLine("Executes before static constructor. Public constructor");
        }

        static Singleton1()
        {
            Console.WriteLine("Executes after instance constructor. static constructor");
        }
        public static Singleton1 obj => obj1;
    }
}
