using System;

namespace hello_world
{
    public class HelloWorld
    {
        public string ReturnMessage()
        {
            var hashProvider = new SHA1CryptoServiceProvider();
            var hash = hashProvider.ComputeHash("Hello World");
            return "Hello World!";
        }
    }
}
