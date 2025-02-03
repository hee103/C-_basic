namespace basic_4week_3_2_
{
    internal class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void PrintMessaage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = Add;
            int result = addFunc(3, 5);
            Console.WriteLine("결과 : "+result);

            Action<string> printAction = PrintMessaage;
            printAction("Hello, world");
        }
    }
}
