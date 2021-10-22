using System;

namespace Singleton
{
    /*
     *     https://www.dofactory.com/net/singleton-design-pattern
     *     https://refactoring.guru/design-patterns/singleton/csharp/example#example-0
     */
    public class Singleton
    {
        static Singleton instance;

        protected Singleton()
        {
        }
        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
