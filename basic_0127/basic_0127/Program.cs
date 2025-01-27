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

            //Console.Write("enter two numbers: ");
            //string input = Console.ReadLine();

            //string[] numbers = input.Split(' ');

            //int num1 = int.Parse(numbers[0]);
            //int num2 = int.Parse(numbers[1]);

            //int sum = num1 + num2;

            //Console.WriteLine("The sum of {0} and {1} is {2}",num1, num2, sum);

            // 1-5 연산자와 문자열 처리
            Console.WriteLine("산술연산자");
            int num1 = 20, num2 = 10;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1-num2);
            Console.WriteLine(num1/num2);
            Console.WriteLine(num1*num2);
            Console.WriteLine(num1%num2);
            Console.WriteLine();

           Console.WriteLine("관계연산자");
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 >= num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine();

            Console.WriteLine("논리연산자");
            int num3 = 15;
            Console.WriteLine(0<=num3 && num3 <=20);// 0고ㅘ 20 사이에 포함
            Console.WriteLine(0 > num3 || num3 > 20);//0~20 사이에 포함되지 않음
            Console.WriteLine(!(0 <= num3 && num3 <= 20));

            
            string str1 = "Hello, world";
            String str2 = new string('h', 5);

            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);

            string[] str4 = str1.Split(",");
            Console.WriteLine(str4[0]);
            Console.WriteLine(str4[1]);

            int index = str1.IndexOf("world");
            Console.WriteLine(index);

            string newStr = str1.Replace("world", "Universe");
            Console.WriteLine(newStr);
            Console.WriteLine(str1);

            string str5 = "123";
            int num = int.Parse(str5);
            Console.WriteLine(num);

            num += 10;

            Console.WriteLine(num.ToString());

            Console.WriteLine(str1==str2);
            Console.WriteLine(string.Compare(str1,str2));

            string name = "John";
            int age = 10;
            string massage = string.Format("My name is {0} and I'm {1} years old",name, age);
            Console.WriteLine(massage);
            massage = $"My name is {name} and I'm {age} years old";
            Console.WriteLine(massage);
        }

    }
}
