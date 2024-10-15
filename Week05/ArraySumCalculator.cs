using System;
using System.Text;

class ArraySumCalculator
{
    static void Main()
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        #endregion

        print.Write("몇 번 입력하시나요? : ");
        int size = Convert.ToInt32(read.ReadLine());

        int[] num = new int[size];
        int idx = 0;
        while (idx < size)
        {
            print.Write($"{idx + 1}번째 숫자를 입력하세요 : ");
            num[idx++] = Convert.ToInt32(read.ReadLine());
        }

        print.Write($"합계 ==> {num.Sum()}");
    }
}
