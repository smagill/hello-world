using System;

namespace hello_world
{
    public class HelloWorld
    {
        private static Hash GetSha1Hash(string filename)
        {
            using (var fs = new FileStream(filename, FileMode.Open))
            using (var bs = new BufferedStream(fs))
            {
                using (var sha1 = new SHA1Managed())
                {
                    byte[] hash = sha1.ComputeHash(bs);
                    StringBuilder formatted = new StringBuilder(2 * hash.Length);
                    foreach (byte b in hash)
                    {
                        formatted.AppendFormat("{0:X2}", b);
                    }
                    return new Hash
                    {
                        Alg = Hash.HashAlgorithm.SHA_1,
                        Content = formatted.ToString().ToLowerInvariant()
                    };
                }
            }
        }
        
        public string ReturnMessage()
        {
            return "Hello World!";
        }
    }
}
