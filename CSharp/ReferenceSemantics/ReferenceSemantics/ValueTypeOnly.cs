using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceSemantics
{
    public ref struct ValueTypeOnly
    {
        public ValueTypeOnly(int data)
        {
            Data = data;
        }
        public int Data { get; }
        public void Foo() => Console.WriteLine(Data);
    }
}
