using System;

using System.Linq;

namespace ReferenceSemantics
{
    class Program
    {
        static void Main()
        {
            var vd = new ValueTypeOnly(42);
            int[] arr = Enumerable.Range(0, 1000).ToArray();
            Span<int> span1 = new Span<int>(arr);
            Span<int> slice1 = span1.Slice(40, 10);
            string s = "this is a long string";
            ReadOnlySpan<char> span2 = s.AsSpan();
            ReadOnlySpan<char> slice2 = span2.Slice(5, 10);


            int answer = 42;
            PassByValue(answer);
            Console.WriteLine(answer);
            PassByRef1(ref answer);
            Console.WriteLine(answer);
            PassByUsingIn(answer);
            Console.WriteLine(answer);

            UseRef1();
            UseRef2();
            UseRef3();
        }

        private static void PassByValue(int x)
        {
            x = 43; // make a copy
        }

        private static void PassByRef1(ref int x)
        {
            x = 43;
        }

        private static void PassByUsingIn(in int x)
        {
            Console.WriteLine($"received {x}");
            // x = 43; // can't change! - readonly
        }

        private static void UseRef1()
        {
            Console.WriteLine($"{nameof(UseRef1)} use ref as value");
            var items = new SomeItems();
            int a = items.GetItem(11);
            Console.WriteLine(a);
            a = 42;
            Console.WriteLine(items.GetItem(11));
        }

        private static void UseRef2()
        {
            Console.WriteLine($"{nameof(UseRef2)} use ref as ref");
            var items = new SomeItems();
            ref int a = ref items.GetItem(11);
            Console.WriteLine(a);
            a = 42;
            Console.WriteLine(items.GetItem(11));
        }

        private static void UseRef3()
        {
            Console.WriteLine($"{nameof(UseRef3)} use ref as ref");
            var items = new SomeItems();
            ref readonly int a = ref items.GetReadonlyItem(11);
            Console.WriteLine(a);
            // a = 42; // can't change!
            Console.WriteLine(items.GetItem(11));
        }
    }
}
