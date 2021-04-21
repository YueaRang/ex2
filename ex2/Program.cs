using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {   //Console.WriteLine("Hello World!");
                Console.WriteLine("원하는 번호를 선택하시오");

                Console.WriteLine("1. 랜덤 구구단");

                Console.WriteLine("2. 원하는 구구단 출력");

                Console.WriteLine("3. 원하는 곱셈 결과 출력");

                Console.WriteLine("4. 프로그램 종료");

                string choose0 = Console.ReadLine();
                int choose = int.Parse(choose0);
                char choose1 = char.Parse(choose0);

                switch (choose)
                {
                    case 1:
                        //랜덤한 두 개의 숫자 출력
                        Random random = new Random();
                        int num1 = 0;  //1번숫자 랜덤값

                        int num2 = 0;  //2번 숫자 랜덤값
                        num1 = random.Next(2, 10);
                        num2 = random.Next(2, 10);

                        int result1;  //결과값


                        result1 = num1 * num2;


                        Console.WriteLine($"{num1} X {num2} = ?");

                        string input0 = Console.ReadLine();
                        int num0 = int.Parse(input0);

                        bool isRight = num0 == result1;

                        if (isRight)
                        {
                            Console.WriteLine("정답입니다.!");
                        }
                        else
                        {
                            Console.WriteLine("오답입니다..!");
                        }


                        break;



                    case 2:
                        Console.Write("원하는 구구단을 입력해주세요 ");
                        string input3 = Console.ReadLine();
                        int num3 = int.Parse(input3);
                        //  입력 받은 숫자 확인
                        Console.WriteLine("입력받은 숫자는 : " + num3 + "단");

                        //y가 1부터 9까지 증가하는 반복문
                        for (int y = 1; y <= 9; y++)
                        {



                            //Console.WriteLine(num1 + "X" + y + " = " + num1 * y); // y : 1 ->9 증가
                            Console.WriteLine($"{num3} X {y} = {num3 * y}"); // num1을 받아오고 그 숫자에 1~9까지 곱한 반복문 출력
                        }

                        break;


                    case 3:

                        string input = Console.ReadLine();
                        string input1 = Console.ReadLine();
                        //  입력 받은 숫자 확인
                        int n1 = int.Parse(input);
                        int n2 = int.Parse(input1);


                        //string mathNum = "1111";
                        //int intValue1 = int.Parse(mathNum);

                        //  구구단 곱셈 연산 출력
                        Console.WriteLine("입력받은 첫번째 숫자는 : " + n1);
                        Console.WriteLine("입력받은 두번째 숫자는 : " + n2);
                        Console.WriteLine("두 숫자의 곱은" + $"{n1} X {n2} = {n1 * n2}");

                        break;

                    case 4:
                        goto exit;

                    

                    default:

                        Console.WriteLine("1~3의 숫자를 적어주세요.");
                        break;

                        
                }

               

            }
            exit:
            Console.WriteLine("종료");


        }
    }
}
