using System;
using System.Text;

class ReverseMultiplicationTable
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

        print.Write("몇 단 ? ");
        int num = Convert.ToInt32(read.ReadLine());

        for (int i = 9; i > 0; i--)
            print.WriteLine($"{num} X {i} = {num * i}");
    }
}