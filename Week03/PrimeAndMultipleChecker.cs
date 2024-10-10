using System;
using System.Text;

class PrimeAndMultipleChecker
{
    static void Main(string[] args)
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        #endregion

        print.Write("정수를 입력하세요 : ");
        int num = Convert.ToInt32(read.ReadLine());
        if (num % 5 == 0 || num % 3 == 0)
            print.WriteLine("3의 배수 또는 5의 배수를 입력했군요.");
        
        // 소수 찾기
        bool found = true;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0 || num <= 1)
            {
                found = false;
                print.Write("소수가 아닙니다.");
                break;
            }
        }

        if (found)
            print.Write("소수입니다.");
    }
}