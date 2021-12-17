using System;
using System.Security.Cryptography;
using System.Text;

namespace hello_world
{
    public class HelloWorld
    {
        public string ReturnMessage()
        {
            using (var sha1 = new SHA1Managed())
            {
                Encoding unicode = Encoding.Unicode;
                byte[] bytes = unicode.GetBytes("Hello World!");
                byte[] hash = sha1.ComputeHash(bytes);
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
