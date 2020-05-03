using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace TimeTracker.Helpers
{
    public static class Encryption
    {
        public static string GenerateHash(string input, int iterations)
        {
            iterations = Math.Min(iterations, 5);
            for (var i = 0; i < iterations; i++)
            {
                input = GenerateHashInternal(input);
            }
            return input;
        }

        private static string GenerateHashInternal(string input)
        {
            byte[] data = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
