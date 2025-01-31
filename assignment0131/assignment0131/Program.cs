//{
//    Random random = new Random();
//    int computer = random.Next(1, 101);
//    bool guessNum = false;


//    int chance = 1;
//    while (!guessNum)
//    {
//        Console.Write("숫자를 맞춰주세요: ");
//        int user = int.Parse(Console.ReadLine());
//        if (computer == user)
//        {
//            Console.WriteLine($"정답입니다~! 시도횟수: {chance}");
//            guessNum = true;
//        }
//        else if (user > computer)
//        {
//            Console.WriteLine($"더 작은 수를 입력해주세요 시도횟수: {chance}");
//            chance++;
//        }
//        else
//        {
//            Console.WriteLine($"더 큰 수를 입력해주세요 시도횟수: {chance}");
//            chance++;
//        }
//    }
//}


using System.Security.Cryptography.X509Certificates;

{

    char currentPlayer = 'X';

    bool gameOver = false;
    while (!gameOver)
    {
        Board();
        Console.Write($"플레이어 {currentPlayer}, 위치 선택 (1-9): ");
        string input = Console.ReadLine();
        

        if (int.TryParse(input, out int position)&&position>=1&&position<=9)
        {

        }
    }

    static void Board()
    {
        int[,] array = new int[3, 3]
        {
            {0,0,0},
            {0,0,0},
            {0,0,0}
         };
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                
                    Console.Write($"{2 * i + j + i + 1} ");
                
            }
            Console.WriteLine();

        }
    }
    

}

