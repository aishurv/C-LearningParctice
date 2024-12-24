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
        public static void sample()
        {
            Console.WriteLine("Sample Static Method called !");
        }
        //public static Singleton Instance => instance;
    }

    public class Singleton1
    {
        public static staticConstructor obj1 = new staticConstructor();
        public Singleton1(string obj )
        {
            Console.WriteLine($"Executes before static constructor. Public constructor {obj}");
        }
        static Singleton1()
        {
            Console.WriteLine("Executes after instance constructor. static constructor");
        }
        public static void sample()
        {
            Console.WriteLine("Sample Static Method called !");

        }
        //public static Singleton1 obj => obj1;
    }
}
