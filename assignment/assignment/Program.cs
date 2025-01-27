namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1번
            //Console.Write("이름을 입력해주세요: ");
            //string name = Console.ReadLine();
            //Console.Write("나이를 입력해주세요: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"제 이름은 {name}입니다. 나이는 {age}살 입니다.");

            //// 2번
            //Console.Write(" 숫자 1을 입력해주세요: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write(" 숫자 2를 입력해주세요: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int sum = num1 + num2;
            //int sub = num1 - num2;
            //int mul = num1 * num2;
            //int div = num1 / num2;
            //int rem = num1 % num2;

            //Console.WriteLine($"{num1} + {num2} = {sum}");
            //Console.WriteLine($"{num1} - {num2} = {sub}");
            //Console.WriteLine($"{num1} X {num2} = {mul}");
            //Console.WriteLine($"{num1} / {num2} = {div}");
            //Console.WriteLine($"{num1} % {num2} = {rem}");

            // 3번
            //Console.Write("현재 섭씨 온도를 입력해주세요(숫자만): ");
            //int celsius = int.Parse(Console.ReadLine());

            //float fahrenheit = 32 + 1.8f*celsius;

            //Console.WriteLine($"현재 화씨 온도는 {fahrenheit}입니다.");

            // 4번
            Console.Write("몸무게(kg)와 키(cm)를 입력해주세요 (예: 70 175): ");
            string data = Console.ReadLine();
            string[] user_data = data.Split(" ");
      
            float weight = float.Parse(user_data[0]); 
            float height_cm = float.Parse(user_data[1]);
            float height_m = height_cm / 100; 
           
            float bmi = weight / (height_m * height_m);
            Console.WriteLine(bmi);


            Console.WriteLine($"당신의 BMI는 {bmi:N2}입니다.");
        }
    }
}
