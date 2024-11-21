using System;
using System.Text;

class SumOfMultiplesCalculator
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

        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
                sum += i;
        }

        print.Write($"1부터 100까지 중 3의 배수의 합계: {sum}");
    }
}