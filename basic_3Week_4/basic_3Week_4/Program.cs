namespace basic_3Week_4
{
    internal class Program
    {
        class Stack<T>
        {
            private T[] elements;
            private int top;

            public Stack()
            {
                elements = new T[100];
                top = 0;
            }

            public void Push(T item)
            {
                elements[top++] = item;
            }

            public T Pop()
            {
                return elements[--top];
            }
        }
        static void Main(string[] args)
        {
            Stack<int> intSta = new Stack<int>();
            intSta.Push(1);
            intSta.Push(2);
            intSta.Push(3);
            Console.WriteLine(intSta.Pop());
        }
    }
}
