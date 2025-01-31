{
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());

    float num = x / y;
    float num2 = x % y *10/y*0.1f;
    float num3 = (num + num2) * 1000;
    Console.WriteLine(num);
    Console.WriteLine(Math.Round(num2, 3));
    Console.WriteLine(num3);
}