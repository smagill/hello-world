using System;

namespace hello_world
{
    public class HelloWorld
    {
        public string ReturnMessage()
        {
            var rnd = new Random();
            byte[] buffer = new byte[16];
            rnd.GetBytes(buffer);
            return BitConverter.ToString(buffer);
        }
    }
}
