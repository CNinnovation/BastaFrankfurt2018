using LegacyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullability
{
    public class ThisIsNew
    {
        public void Foo(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var legacy = new Legacy();
            legacy.Foo(null); // passing null is ok

            var newer = new ThisIsNew();
            newer.Foo(null!); // passing null is not ok

            Book[] books = new Book[3];
            books[0] = new Book("Professional C# 7");
            Console.WriteLine(books[0].Title);
            string publisher = books[0].Publisher ?? string.Empty;

            Console.WriteLine(books[0].Publisher!);
        }
    }
}
