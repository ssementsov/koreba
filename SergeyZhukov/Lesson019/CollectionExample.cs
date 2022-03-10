using System.Collections;
using System.Text;

namespace Lesson019
{
    internal class CollectionExample
    {
        public void ExecuteTask()
        {
            var arrayList = new ArrayList { 1, 2, 3, 4, 5 };
            var genericList = new List<int> { 11, 15, 13, 10, 12 };

            int first = 111;
            int second = 222;

            arrayList.Add(first);
            arrayList.Add(second);
            PrintList(arrayList);

            genericList.Add(first);
            genericList.Add(second);
            PrintList(genericList);

            Console.WriteLine("Removed element at index 3");
            genericList.RemoveAt(3);
            PrintList(genericList);

            Console.WriteLine($"Removed element first = {first}");
            genericList.Remove(first);
            PrintList(genericList);

            Console.WriteLine("Sorted generic list");
            genericList.Sort();
            PrintList(genericList);
        }

        private void PrintList(IEnumerable list)
        {
            StringBuilder sb = new StringBuilder()
                .Append($"{list.GetType()}: ");

            foreach (var item in list)
            {
                sb.Append($"{item} ");
            }

            sb.Append("\n");
            Console.WriteLine(sb.ToString());
        }
    }
}
