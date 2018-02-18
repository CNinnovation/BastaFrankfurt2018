using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferenceSemantics
{
    public class SomeItems
    {
        private readonly int[] _items = Enumerable.Range(0, 1000).ToArray();
        public SomeItems()
        {

        }

        public ref int GetItem(int index)
        {
            return ref _items[index];
        }

        public ref readonly int GetReadonlyItem(int index)
        {
            return ref _items[index];
        }
    }
}
