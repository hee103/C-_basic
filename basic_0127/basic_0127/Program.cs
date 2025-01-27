namespace basic_0127
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); //출력 후 자동 개행
            Console.WriteLine("MY name is heewon");
            Console.WriteLine("C#");

            Console.WriteLine(10);
            Console.WriteLine(3.141592); // double
            Console.WriteLine(3+3);

            Console.Write("Hello!"); //출력 후 자동 개행 X
            Console.Write(" We are learning");
            Console.Write("at TeamSparta");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }
        }

    }
}
