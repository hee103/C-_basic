﻿{
    // 게임 캐릭터의 능력치 배열 만들기
    // 플레이어의 공격력, 방어력, 체력, 스피드를 저장할 배열

    //int[] playerStats = new int[4];

    ////능력치를 랜덤으로 생성하여 배열게 저장
    //Random random = new Random();
    //for (int i = 0; i < playerStats.Length; i++)
    //{
    //    playerStats[i] = random.Next(1,11);
    //}

    //Console.WriteLine("플레이어의 공격력: " + playerStats[0]);
    //Console.WriteLine("플레이어의 방어략: " + playerStats[1]);
    //Console.WriteLine("플레이어의 체력: " + playerStats[2]);
    //Console.WriteLine("플레이어의 스피드: " + playerStats[3]);
}

{
    // 학생들의 성적 평균 구하기
    //int[] scores = new int[5];

    //for (int i = 0; i < scores.Length; i++)
    //{
    //    Console.Write("학생" + (i + 1) + "의 성적을 입력하세요");
    //    scores[i] = int.Parse(Console.ReadLine());
    //}

    //int sum = 0;
    //for (int i = 0; i < scores.Length; i++)
    //{
    //    sum +=scores[i];
    //}
    //double average = (double)sum/scores.Length;
    //Console.WriteLine("성적 평균은"+average+"입니다.");
}

{
    // 배열을 활용한 숫자 맞추기 게임
    //Random random = new Random();
    //int[] num = new int[3];

    //for (int i = 0; i < num.Length; i++)
    //{
    //    num[i] = random.Next(0, 10);
    //}

    //int attempt = 0;
    //while (true)
    //{
    //    Console.Write("3개의 숫자를 입력해주세요: ");
    //    int[] guesses = new int[3];

    //    for (int i = 0;i < guesses.Length;i++)
    //    {
    //        guesses[i] = int.Parse(Console.ReadLine());

    //    }

    //    int correct = 0;
    //    for (int i = 0; i < num.Length; i++)
    //    {
    //        for (int j = 0; j < guesses.Length; j++)
    //        {
    //            if (num[i] == guesses[j])
    //            {
    //                correct++;
    //                break;
    //            }
    //        }
    //    }
    //    attempt++; 
    //    Console.WriteLine("시도 #"+attempt+":"+correct+"개의 숫자를 맞추셨씁니다,");

    //    if (correct == 3)
    //    {
    //        Console.WriteLine("축하합니다 모든 숫자를 맞추셨습니다.");
    //        break;
    //    }
    //}

}

{
    // 2차원 배열을 사용하여 게임 맵을 구현
    //int[,] map = new int[5, 5]
    //{
    //    {1,1,1,1,1 },
    //    {1,0,0,0,1 },
    //    {1,0,1,0,1 },
    //    {1,0,0,0,1 },
    //    {1,1,1,1,1 }
    //};

    //for (int i = 0; i < 5; i++)
    //{
    //    for (int j = 0; j < 5; j++)
    //    {
    //        if (map[i,j]==1)
    //        {
    //            Console.Write("■ ");
    //        }
    //        else
    //        {
    //            Console.Write("□ ");
    //        }
    //    }
    //    Console.WriteLine();
    //}
}

{
    List<int> list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);

    list.Remove(2);

    for (int i = 0; i< list.Count; i++)
    {
        Console.WriteLine(list[i]);
    }

    foreach (int i in list)
    {
        Console.WriteLine(i);
    }
}