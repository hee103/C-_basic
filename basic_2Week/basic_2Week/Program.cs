namespace basic_2Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// [코드스니펫] if문 기초
            //int playerScore = 80;

            //if (playerScore >= 0)
            //{
            //    Console.WriteLine("플레이어의 점수는 70점 이상입니다. 합격입니다!");
            //}
            //Console.WriteLine("프로그램을 종료합니다.");



            //// [코드스니펫] else문 기초
            //int itemCount = 0;
            //string itemName = "HP 포션";

            //if (itemCount > 0)
            //{
            //    Console.WriteLine($"보유한 {itemName}의 수량 : {itemCount}");
            //}
            //else
            //{
            //    Console.WriteLine($"보유한 {itemName}이 없습니다.");
            //}


            //// else if문 실습
            //int score = 100;
            //string playerRank = "";

            //if (score >= 90)
            //{
            //    playerRank = "Diamond";
            //}
            //else if(score >= 80)
            //{
            //    playerRank = "Platinum";
            //}
            //else if(score >= 70)
            //{
            //    playerRank = "Gold";
            //}
            //else if(score >= 60)
            //{
            //    playerRank = "Silver";
            //}
            //else
            //{
            //    playerRank = "Bronze";
            //}

            //Console.WriteLine("플레이어의 등급은 {0} 입니다.", playerRank);


            //// [코드스니펫] switch문 기초
            //Console.WriteLine("게임을 시작합니다,");
            //Console.WriteLine("1: 전사 / 2: 마법사 / 3: 궁수");
            //Console.Write("직업을 선택하세요");
            //string job = Console.ReadLine();

            //switch(job)
            //{
            //    case "1":
            //        Console.WriteLine("전사를 선택하셨습니다.");
            //        break;
            //    case "2":
            //        Console.WriteLine("마법사를 선택하셧습니다");
            //        break;
            //    case "3":
            //        Console.WriteLine(" 궁수를 선택하셨습니다.");
            //        break;
            //    default:
            //        Console.WriteLine(" 올바를 숫자를 입력해주세요");
            //        break;
            //}
            //Console.WriteLine("게임을 종료합니다,");




            // 1) 홀수 / 짝수 구분하기
            //Console.Write("번호를 입력하세요");
            //int number = int.Parse( Console.ReadLine() );

            //if (number%2 ==  0)
            //{
            //    Console.WriteLine("짝수입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("홀수입니다.");
            //}

            // 2) 등급 출력
            //int playerScore = 100;
            //string playerRank = " ";

            //switch(playerScore/10)
            //{
            //    case 10:
            //    case 9:
            //        playerRank = "Diamond";
            //        break;
            //    case 8:
            //        playerRank = "Platinum";
            //        break;
            //    case 7:
            //        playerRank = "Gold";
            //        break;
            //    case 6:
            //        playerRank = "Silver";
            //        break;
            //    default:
            //        playerRank = "Bronze";
            //        break;

            //}
            //Console.Write(playerRank);

            // 3) 로그인 프로그램
            //string id = "id";
            //string password = "pw";

            //Console.Write("아이디를 입력해주세요");
            //string inputId = Console.ReadLine();
            //Console.Write("비밀번호를 입력하세요");
            //string inputPassword = Console.ReadLine();

            //if (id == inputId && password == inputPassword) 
            //{
            //    Console.WriteLine("성공");
            //}
            //else
            //{
            //    Console.WriteLine("실패");
            //}

            // 4) 알파벳 판별 프로그램
            //Console.Write("문자를 입력하세요");
            //char input = Console.ReadLine()[0];

            //if ((input >= 'a' && input <= 'z')|| (input >= 'A' && input <= 'Z'))
            //{
            //    Console.WriteLine("알파벳입니다");
            //}
            //else
            //{
            //    Console.WriteLine("알파벳이 아닙니다.");
            //}




            // [코드스니펫] for문 기초
            //int i = 0;
            //for (i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            ////[코드스니펫] while문 기초
            //int j = 0;
            //while (j < 10) 
            //{
            //    Console.WriteLine(j);
            //    j++;

            //}

            ////[코드스니펫] 구구단 출력
            //for (int k = 2; k <= 9; k++)
            //{
            //    for (int m = 1; m <= 9; m++)
            //    {
            //        Console.WriteLine(k + " x " + m + " = " + (k * m)+"\t");
            //    }
            //    Console.WriteLine();
            //}

            //[코드스니펫] break와 continue 기초
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue; // 3의 배수인 경우 다음 숫자로 넘어감
            //    }

            //    Console.WriteLine(i);
            //    if (i == 7)
            //    {
            //        break; // 7이 출력된 이후에는 반복문을 빠져나감
            //    }
            //}

            // [코드스니펫] break와 continue 예제
            int sum = 0;

            while (true)
            {
                Console.Write("숫자를 입력하세요: ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }

                if (input < 0)
                {
                    Console.WriteLine("음수는 무시합니다.");
                    continue;
                }

                sum += input;
                Console.WriteLine("현재까지의 합: " + sum);
            }

            Console.WriteLine("합계: " + sum);
        }
    }
}
