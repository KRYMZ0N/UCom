using System;

namespace util
{
    class funcs 
    {
    public String Random(string[] s)
        {
            var rand = new Random();

            return s[rand.Next(s.Length)];

        }
    }
}