using System;
using System.Linq;

namespace SpanSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Enumerable.Range(0, 1000).ToArray();
            Span<int> span1 = arr.AsSpan();
            Span<int> slice1 = span1.Slice(40, 10);
            
            string s = "this is a long string";

            
            ReadOnlySpan<char> span2 = s.AsReadOnlySpan();
            ReadOnlySpan<char> slice2 = span2.Slice(5, 10);
            bool whitespace = slice2.IsWhiteSpace();
            int index = slice2.LastIndexOf('l');
            string s2 = "is a";
            ReadOnlySpan<char> span3 = s2.AsReadOnlySpan();
            bool overlap = slice2.Overlaps(span3);
        }
    }
}
