using System;
using System.Text;

class HeartPattern
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

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4 - i; j++)
                print.Write(" ");

            for (int j = 0; j <= i * 2; j++)
                print.Write("♥");

            print.WriteLine();
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j <= i; j++)
                print.Write(" ");

            for (int j = 1; j < (4 - i) * 2; j++)
                print.Write("♥");

            print.WriteLine();
        }
    }
}