using System.Linq;

namespace ReferenceSemantics
{
    public class SomeItems
    {
        private readonly int[] _items = Enumerable.Range(0, 1000).ToArray();

        public ref int GetItem(int index) =>
            ref _items[index];

        public ref readonly int GetReadonlyItem(int index) =>
            ref _items[index];
    }
}
