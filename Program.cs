using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            var _helloWorld = new HelloWorld();
            Console.WriteLine(_helloWorld.ReturnMessage());
        }
    }
}
