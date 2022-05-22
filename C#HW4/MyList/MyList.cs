// See https://aka.ms/new-console-template for more information
namespace MyList
{
    public class MyList
    {
        static void Main(string[] args)
        {
            MyList<int> myList= new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            Console.WriteLine(myList.Remove(1));
            Console.WriteLine(myList.Contains(1));
            Console.WriteLine(myList.Contains(2));
            myList.Clear();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.InsertAt(6,1);
            myList.DeleteAt(2);
            Console.WriteLine(myList.Find(1));
            Console.WriteLine(myList.Find(2));
        }
    }

    public class MyList<T>
    {
        private List<T> data = new List<T>();

        public void Add(T element)
        {
            data.Add(element);
        }

        public T Remove(int index)
        {
            T element = data[index];
            data.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return data.Contains(element);
        }

        public void Clear()
        {
            data.Clear();
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index >= data.Count)
            {
                throw new ArgumentOutOfRangeException($"{index}");
            } else
            {
                data.Insert(index, element);
            }
        }

        public void DeleteAt(int index)
        {
            data.RemoveAt(index);
        }

        public T Find(int index)
        {
            return data[index];
        }
    }
}
