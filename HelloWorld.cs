using System;

namespace hello_world
{
    public class HelloWorld
    {
        public string ReturnMessage()
        {
            using (var sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash("Hello World!");
                StringBuilder formatted = new StringBuilder(2 * hash.Length);
                foreach (byte b in hash)
                {
                    formatted.AppendFormat("{0:X2}", b);
                }
                return formatted.ToString();
            }
        }
    }
}
