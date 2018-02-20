using System;

namespace LegacyLib
{
    public class Legacy
    {
        public void Foo(string s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));

            Console.WriteLine(s.ToUpper());
        }
    }
}
