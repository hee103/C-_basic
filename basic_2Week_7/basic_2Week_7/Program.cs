using System;

namespace basic_2Week_7
{
    internal class Program
    {
        //static void printline()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        console.write("=");
        //    }
        //    console.writeline();
        //}
        //static void printline2(int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        console.write("=");
        //    }
        //    console.writeline();
        //}
        //static int add(int a, int b)
        //{
        //    return a + b;
        //}

        //static int AddNumbers(int a, int b)
        //{
        //    return a + b;
        //}
        //static float AddNumbers(float a, float b)
        //{
        //    return a + b;
        //}
        //static int AddNumbers(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        static void countDown(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine(n);
                countDown(n - 1);
            }
        }
        static void Main(string[] args)
        {
            //printline();
            //printline2(20);
            //int result = add(10, 20);
            //console.writeline(result);
            //int num1 = AddNumbers(10, 20);
            //float num2 = AddNumbers(10.5f, 21.5f);
            //int num3 = AddNumbers(10, 20, 30);

            countDown(5);
        }
    }
}




 