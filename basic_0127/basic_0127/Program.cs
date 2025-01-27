namespace basic_0127
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-2 프러그래밍 기본 요소
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

            //1-3 변수와 자료형 1, 2
            //Console.Write("Enter your name: ");
            //string name  = Console.ReadLine();
            //Console.WriteLine("Hi, {0}!", name); // ctrl K + C로 자동 주석 +u로 주석 풀기

            Console.Write("enter two numbers: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);

            int sum = num1 + num2;

            Console.WriteLine("The sum of {0} and {1} is {2}",num1, num2, sum);


       
        }

    }
}
