using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace castle_web.Helpers
{
    public class GenerateUrl
    {
        private static string symbols = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-";
        private static Random random = new Random();

        public static string GenerateUrlString()
        {
            string url = string.Empty;
            int charIndex;
            for (int i = 0; i < 40; i++)
            {
                charIndex = random.Next(0, symbols.Length);
                url += symbols[charIndex];
            }

            return url;
        }
    }
}